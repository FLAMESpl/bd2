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
                if (db.Visits.HasOverlappingWith(visit))
                    throw new DomainException("Visit already scheduled for this hour");

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
                if (visit.Status == VisitStatus.Finalised.ToCode())
                    throw new DomainException("Finalised visits cannot be cancelled");

                visit.Status = VisitStatus.Cancelled.ToCode();
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

        public static List<Visit> GetInDate(DateTime day)
        {
            using (var db = DataContextFactory.Create(x => x.Include<Visit>(v => v.Patient).Include<Visit>(v => v.Doctor)))
            {
                var result = db.Visits.Where(v => day.Date == v.PlannedDate.Date);
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
    }
}
