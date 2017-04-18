using Clinic.Data;
using Clinic.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Facades.Visits
{
    public static class VisitsService
    {
        public static void Add(Visit visit)
        {
            using (var db = DataContextFactory.Create())
            {
                db.Visits.InsertOnSubmit(visit);
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
