using Clinic.Data;
using Clinic.Facades.Doctors;
using Clinic.Facades.Patients;
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
            Doctor = visit.Doctor.GetFullName();
            Patient = visit.Patient.GetFullName();
            Status = VisitStatusExtensions.GetFromCode(visit.Status);
        }

        public void Reserve(long id, string doctor, string patient)
        {
            VisitId = id;
            Doctor = doctor;
            Patient = patient;
            Status = VisitStatus.Scheduled;
        }

        public void Cancel()
        {
            Status = VisitStatus.Cancelled;
        }

        public void Delete()
        {
            Status = VisitStatus.Scheduled;
            VisitId = null;
            Doctor = null;
            Patient = null;
        }
    }
}
