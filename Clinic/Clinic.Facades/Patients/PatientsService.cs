using Clinic.Data;
using Clinic.Data.Helpers;
using Clinic.Facades.Common;
using System;
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
                if (!patient.Addresses.Any())
                    throw new DomainException("Address for patient must be provided");

                patient.Addresses.AssertDataIsNotEmpty();

                db.Patients.InsertOnSubmit(patient);
                db.SubmitChanges();
            }
        }

        public static void Update(Patient patient)
        {
            using (var db = DataContextFactory.Create())
            {
                var oldPatient = db.Patients.Where(p => p.Id == patient.Id).Single();

                oldPatient.Name = patient.Name;
                oldPatient.PESEL = patient.PESEL;
                oldPatient.Surname = patient.Surname;

                db.UpdateAddressesFor(oldPatient, patient.Addresses);
                db.SubmitChanges();
            }
        }

        public static List<Patient> Match(Patient searchCriteria)
        {
            using (var db = DataContextFactory.Create(x => x.Include<Patient>(p => p.Addresses)))
            {
                var results = db.Patients.Where(p => p.Name.Contains(searchCriteria.Name)
                                && p.Surname.Contains(searchCriteria.Surname)
                                && p.PESEL.Contains(searchCriteria.PESEL));
                return results.ToList();
            }
        }

        private static void UpdateAddressesFor(this ClinicDataContext db, Patient patient, IEnumerable<Address> addresses)
        {
            var addressesToInsert = patient.Addresses.NewAddresses(addresses);
            if (addressesToInsert.Any())
            {
                addressesToInsert.AssertDataIsNotEmpty();
                foreach (var addr in patient.Addresses)
                {
                    addr.IsValid = false;
                }

                patient.Addresses.AddRange(addressesToInsert);
            }
        }

        private static void AssertDataIsNotEmpty(this IEnumerable<Address> addresses)
        {
            if (addresses.Any(a =>
                    String.IsNullOrWhiteSpace(a.City) ||
                    String.IsNullOrWhiteSpace(a.Street) ||
                    String.IsNullOrWhiteSpace(a.FlatNumber) ||
                    String.IsNullOrWhiteSpace(a.HouseNumber))
               )
            {
                throw new DomainException("Any of address data cannot be empty");
            }
        }

        private static IEnumerable<Address> NewAddresses(this IEnumerable<Address> old, IEnumerable<Address> @new)
        {
            foreach (var addr in @new)
                if (!old.Select(a => a.Id).Contains(addr.Id))
                    yield return addr;
        }

        public static Patient GetPatientById(long PatientId)
        {
            using (var db = DataContextFactory.Create())
            {
                Patient results = db.Patients.Where(x => x.Id == PatientId).Single();
                return results;
            }
        }
    }
}
