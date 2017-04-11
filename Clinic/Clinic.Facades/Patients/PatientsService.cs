using Clinic.Data;
using System.Collections.Generic;
using System.Linq;

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

        public static List<Patient> MatchPatients(Patient searchCriteria)
        {
            using (var db = new ClinicDataContext())
            {
                var result = db.Patients.Where(p => p.name.Contains(searchCriteria.name)
                                && p.surname.Contains(searchCriteria.surname));
                return result.ToList();
            }
        }
    }
}
