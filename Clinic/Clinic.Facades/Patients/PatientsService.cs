﻿using Clinic.Data;
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
                var oldPatient = db.Patients.Where(p => p.Id == patient.Id).Single();

                oldPatient.Name = patient.Name;
                oldPatient.PESEL = patient.PESEL;
                oldPatient.Surname = patient.Surname;

                db.UpdateAddressesFor(oldPatient, patient.Addresses);
                db.SubmitChanges();
            }
        }

        //public static int Delete(Patient patient)
        //{
        //    using (var db = DataContextFactory.Create())
        //    {
        //        try
        //        {
        //            db.Patients.DeleteOnSubmit(patient);
        //            db.SubmitChanges();
        //        }
        //        catch (System.Exception e)
        //        {
        //            System.Console.WriteLine(e.Message);
        //            System.Console.WriteLine();
        //        }
        //    }
        //    return 0;
        //}

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
            db.Addresses.DeleteAllOnSubmit(patient.Addresses);
            patient.Addresses.AddRange(addresses);
        }
    }
}
