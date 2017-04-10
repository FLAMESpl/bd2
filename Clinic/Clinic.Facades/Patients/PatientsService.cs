using Clinic.Data;

namespace Clinic.Facades.Patients
{
    public static class PatientsService
    {
        public static void AddPatient(Patient patient)
        {
            using (var db = new ClinicDataContext())
            {
                db.Patients.InsertOnSubmit(patient);
                db.SubmitChanges();
            }
        }
    }
}
