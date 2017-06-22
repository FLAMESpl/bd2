using System.Linq;
using Clinic.Data;
using Clinic.Data.Helpers;
using System.Collections.Generic;

namespace Clinic.Facades.Tests
{
    public static class TestService
    {
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

        public static List<LaboratoryTest> GetAllScheduled()
        {
            using (var db = DataContextFactory.Create())
            {
                var result = db.LaboratoryTests.Where(t => t.Status == TestStatus.Scheduled.ToCode());
                return result.ToList();
            }
        }

        public static List<LaboratoryTest> GetAllExecuted()
        {
            using (var db = DataContextFactory.Create())
            {
                var result = db.LaboratoryTests.Where(t => t.Status == TestStatus.Executed.ToCode());
                return result.ToList();
            }
        }
    }
}
