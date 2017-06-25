using System.Linq;
using Clinic.Data;
using Clinic.Data.Helpers;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
using System;

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

        public static void Update(TestDictionary dict)
        {
            using (var db = DataContextFactory.Create())
            {
                var oldDictionary = db.TestDictionaries.Where(x => x.Code == dict.Code).Single();
                oldDictionary.Name = dict.Name;
                oldDictionary.Type = dict.Type;
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

        public static bool DictionaryRecordAlreadyExists(TestDictionary newRecord)
        {
            using (var db = DataContextFactory.Create())
            {
                return db.TestDictionaries.Any(td => td.Code == newRecord.Code);
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

        public static void Add(PhysicalTest test)
        {
            using (var db = DataContextFactory.Create(x => x.Include<Visit>(y => y.PhysicalTests))) //not needed
            {
                db.PhysicalTests.InsertOnSubmit(test);
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

        public static void UpdateLaboratoryTestAsDoctor(LaboratoryTest test)
        {
            using (var db = DataContextFactory.Create())
            {
                var oldTest = db.LaboratoryTests.Where(p => p.Id == test.Id).Single();
                oldTest.DoctorNotes = test.DoctorNotes;
                db.SubmitChanges();
            }
        }
		
        public static void UpdatePhysicalTest(PhysicalTest test)
        {
            using (var db = DataContextFactory.Create())
            {
                var oldTest = db.PhysicalTests.Where(p => p.Id == test.Id).Single();
                oldTest.Result = test.Result;
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

        public static List<LaboratoryTest> GetTestsOfStatus(TestStatus queryStatus, long? VisitId = null)
        {
            using (var db = DataContextFactory.Create())
            {
                var result = db.LaboratoryTests.Where(t => t.Status == queryStatus.ToCode());
                if (VisitId != null)
                {
                    result = result.Where(t => t.IdVisit == VisitId);
                }
                return result.ToList();
            }
        }

        public static List<PhysicalTest> GetPhysicalTests(long? VisitId = null)
        {
            using (var db = DataContextFactory.Create())
            {
                var result = db.PhysicalTests.Select(x => x); //this select is here just so we dont have to cast three lines below
                if (VisitId != null)
                {
                    result = result.Where(t => t.IdVisit == VisitId);
                }
                return result.ToList();
            }
        }
    }
}
