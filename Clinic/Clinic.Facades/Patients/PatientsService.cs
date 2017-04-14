using Clinic.Data;
using Clinic.Data.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Facades.Patients
{
    public static class PatientsService
    {
        public static void Add(Patient patient)
        {
            using (var db = DataContextFactory.Create())
            {
                db.Patients.InsertOnSubmit(patient);
                db.SubmitChanges();
            }
        }

        public static void Update(Patient patient)
        {
            using (var db = DataContextFactory.Create())
            {
                var oldPatient = db.Patients.Where(p => p.id_pat == patient.id_pat).Single();

                oldPatient.name = patient.name;
                oldPatient.PESEL = patient.PESEL;
                oldPatient.surname = patient.surname;

                db.UpdateAddressesFor(oldPatient, patient.Addresses);
                db.SubmitChanges();
            }
        }

        public static List<Patient> Match(Patient searchCriteria)
        {
            using (var db = DataContextFactory.Create(x => x.Include<Patient>(p => p.Addresses)))
            {
                var results = db.Patients.Where(p => p.name.Contains(searchCriteria.name)
                                && p.surname.Contains(searchCriteria.surname));
                return results.ToList();
            }
        }

        private static void UpdateAddressesFor(this ClinicDataContext db, Patient patient, IEnumerable<Address> addresses)
        {
            db.Addresses.DeleteAllOnSubmit(patient.Addresses);
            //db.Addresses.AttachAndDelete(replicas);
            patient.Addresses.AddRange(addresses);
        }
    }
}
