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
            VisitId = visit.id_visit;
            Doctor = visit.Doctor.name + visit.Doctor.surname;
            Patient = visit.Patient.name + visit.Patient.surname;
            Status = VisitStatusExtensions.GetFromCode(visit.status);
        }
    }
}
