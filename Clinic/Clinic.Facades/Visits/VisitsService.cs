using Clinic.Data;
using Clinic.Data.Helpers;
using Clinic.Facades.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Facades.Visits
{
    public static class VisitsService
    {
        public static long Add(Visit visit)
        {
            using (var db = DataContextFactory.Create())
            {
                visit.AssertIsNotOverlappingWithAnotherVisit(db.Visits);

                db.Visits.InsertOnSubmit(visit);
                db.SubmitChanges();
                return visit.Id;
            }
        }

        public static void Cancel(long id)
        {
            using (var db = DataContextFactory.Create())
            {
                var visit = db.Visits.Single(v => v.Id == id);

                visit.Status = VisitStatus.Cancelled.ToCode();
                visit.ResolutionDate = db.GetSystemDate();
                db.SubmitChanges();
            }
        }

        public static void Update(Visit updatedVisit) //updates visit diagnosis
        {
            using (var db = DataContextFactory.Create())
            {
                var oldVisit = db.Visits.Single(x => x.Id == updatedVisit.Id);
                oldVisit.Diagnosis = updatedVisit.Diagnosis;
                db.SubmitChanges();
            }
        }

        public static void Delete(long id)
        {
            using (var db = DataContextFactory.Create())
            {
                var visit = db.Visits.Single(v => v.Id == id);
                if (visit.Status == VisitStatus.Finalised.ToCode())
                    throw new DomainException("Finalised visits cannot be deleted");

                if (visit.Status == VisitStatus.Cancelled.ToCode())
                    throw new DomainException("Cancelled visits cannot be deleted");

                visit.Status = VisitStatus.Removed.ToCode();
                db.SubmitChanges();
            }
        }

        public static void Finalise(long id)
        {
            using (var db = DataContextFactory.Create())
            {
                var visit = db.Visits.Single(v => v.Id == id);
                if (visit.Status != VisitStatus.Scheduled.ToCode())
                    throw new DomainException("Only scheduled visits can be finalised");

                visit.Status = VisitStatus.Finalised.ToCode();
                db.SubmitChanges();
            }
        }

        public static List<Visit> GetInDate(DateTime day, long? doctorId = null)
        {
            using (var db = DataContextFactory.Create(x => x.Include<Visit>(v => v.Patient).Include<Visit>(v => v.Doctor)))
            {
                var result = db.Visits.Where(v => day.Date == v.PlannedDate.Date);
                if (doctorId.HasValue)
                    result = result.Where(v => v.IdDoctor == doctorId.Value);

                return result.ToList();
            }
        }

        public static List<Visit> GetInDateRange(DateTime firstDay, DateTime lastDay)
        {
            using (var db = DataContextFactory.Create())
            {
                var result = db.Visits.Where(v => firstDay <= v.PlannedDate && v.PlannedDate >= lastDay);
                return result.ToList();
            }
        }

        public static Visit GetVisitById(long id)
        {
            using (var db = DataContextFactory.Create())
            {
                Visit result = db.Visits.Where(v => v.Id == id).Single();
                return result;
            }
        }
    }
}
