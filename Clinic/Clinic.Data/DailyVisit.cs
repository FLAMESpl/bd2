using System;

namespace Clinic.Data
{
    public class DailyVisit
    {
        public long? VisitId { get; set; }
        public DateTime VisitHour { get; set; }
        public string Doctor { get; set; }
        public string Patient { get; set; }
        public VisitStatus Status { get; set; }

        public DailyVisit()
        {
        }

        public DailyVisit(Visit visit)
        {
            VisitId = visit.Id;
            Doctor = $"{visit.Doctor.Name} {visit.Doctor.Surname}";
            Patient = $"{visit.Patient.Name} {visit.Patient.Surname}";
            Status = VisitStatusExtensions.GetFromCode(visit.Status);
        }
    }
}
