using System.Linq;
using Clinic.Data;
using Clinic.Data.Helpers;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;

namespace Clinic.Facades.Tests
{
    public static class TestService
    {
        public static List<TestDictionary> GetDictionary()
        {
            using (var db = DataContextFactory.Create(x => x.Include<LaboratoryTest>(y => y.TestDictionary)))
            {
                var results = db.TestDictionaries;
                return results.ToList();
            }
        }

        public static void Add(TestDictionary dict)
        {
            using (var db = DataContextFactory.Create())
            {
                db.TestDictionaries.InsertOnSubmit(dict);
                db.SubmitChanges();
            }
        }

        public static List<TestDictionary> Match(TestDictionary searchCriteria)
        {
            using (var db = DataContextFactory.Create())
            {
                var results = db.TestDictionaries.Where(t => t.Name.Contains(searchCriteria.Name)
                                && t.Type.Contains(searchCriteria.Type)
                                && t.Code.Contains(searchCriteria.Code));
                return results.ToList();
            }
        }

        public static void Add(LaboratoryTest test)
        {
            using (var db = DataContextFactory.Create(x => x.Include<Visit>(y => y.LaboratoryTests)))
            {
                db.LaboratoryTests.InsertOnSubmit(test);
                db.SubmitChanges();
            }
        }

        public static void UpdateAsAssistant(LaboratoryTest test)
        {
            using (var db = DataContextFactory.Create())
            {
                var oldTest = db.LaboratoryTests.Where(p => p.Id == test.Id).Single();

                oldTest.ExecutionDate = test.ExecutionDate;
                oldTest.IdLabAssistant = test.IdLabAssistant;
                oldTest.Result = test.Result;
                oldTest.Status = test.Status;
                db.SubmitChanges();
            }
        }

        public static void UpdateAsManager(LaboratoryTest test)
        {
            using (var db = DataContextFactory.Create())
            {
                var oldTest = db.LaboratoryTests.Where(p => p.Id == test.Id).Single();

                oldTest.ResolutionDate = test.ResolutionDate;
                oldTest.IdLabManager = test.IdLabManager;
                oldTest.ManagerNotes = test.ManagerNotes;
                oldTest.Status = test.Status;
                db.SubmitChanges();
            }
        }

        public static List<LaboratoryTest> GetAll(TestStatus ts)
        {
            using (var db = DataContextFactory.Create(x => x.Include<Visit>(y => y.LaboratoryTests)))
            {
                var result = db.LaboratoryTests.Where(t => t.Status == ts.ToCode());
                return result.ToList();
            }
        }

        public static List<PatientLaboratoryTest> MatchWithPatient(string name, string surname, TestStatus ts)
        {
            using (var db = DataContextFactory.Create(x => x.Include<Visit>(y => y.LaboratoryTests)))
            {
                var result = from t in db.LaboratoryTests
                             join v in db.Visits on t.IdVisit equals v.Id
                             join p in db.Patients on v.IdPatient equals p.Id
                             join d in db.TestDictionaries on t.Code equals d.Code
                             where t.Status == ts.ToCode()
                             where SqlMethods.Like(p.Name, "%" + name + "%")
                             where SqlMethods.Like(p.Surname, "%" + surname + "%")
                             select new PatientLaboratoryTest
                             {
                                 Id = t.Id,
                                 Test = d.Name,
                                 CommissionDate = t.ComissionDate,
                                 ExecutionDate = t.ExecutionDate,
                                 DoctorNotes = t.DoctorNotes,
                                 Name = p.Name,
                                 Surname = p.Surname,
                                 Result = t.Result
                             };
                return result.ToList();
            }
        }
    }
}
