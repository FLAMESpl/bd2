using Clinic.Data;
using System;

namespace Clinic.Facades.Visits
{
    public class DailyVisit
    {
        public long? VisitId { get; set; }
        public DateTime VisitHour { get; set; }
        public string Doctor { get; set; }
        public string Patient { get; set; }
        public VisitStatus Status { get; set; }

        public DailyVisit(DateTime visitHour)
        {
            VisitHour = visitHour;
        }

        public DailyVisit(Visit visit)
        {
            VisitId = visit.Id;
            VisitHour = visit.PlannedDate;
            Doctor = $"{visit.Doctor.Name} {visit.Doctor.Surname}";
            Patient = $"{visit.Patient.Name} {visit.Patient.Surname}";
            Status = VisitStatusExtensions.GetFromCode(visit.Status);
        }
    }
}
