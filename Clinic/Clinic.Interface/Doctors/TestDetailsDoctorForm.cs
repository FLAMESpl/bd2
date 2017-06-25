using Clinic.Data;
using Clinic.Facades.Tests;
using Clinic.Facades.Visits;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.Interface.Doctors
{
    public partial class TestDetailsDoctorForm : ClinicForm
    {
        private DataGridViewRow Row;
        Visit SelectedVisit;
        long SelectedVisitId;

        public TestDetailsDoctorForm(DataGridViewRow row)
        {
            InitializeComponent();
            Row = row;
            SelectedVisit = VisitsService.GetVisitById(long.Parse(Row.Cells["visitIdDataGridViewTextBoxColumn"].Value.ToString()));
            SelectedVisitId = (long.Parse(Row.Cells["visitIdDataGridViewTextBoxColumn"].Value.ToString()));

            TestDictionaryBindingSource.Clear();
            TestDictionaryBindingSource.AddRange(TestService.GetDictionary());
            ScheduledTestsBindingSource.Clear();
            ScheduledTestsBindingSource.AddRange(TestService.GetTestsOfStatus(TestStatus.Scheduled, SelectedVisitId));
            ApprovedTestsBindingSource.Clear();
            ApprovedTestsBindingSource.AddRange(TestService.GetTestsOfStatus(TestStatus.Approved, SelectedVisitId));
            PhysicalTestBindingSource.Clear();
            PhysicalTestBindingSource.AddRange(TestService.GetPhysicalTests(SelectedVisitId));
        }

        private void btnTestDetailsDoctorReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoctorAssignTest_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection SelectedTests = dataGridTestDictionary.SelectedRows;
            int testamountadded = 0;

            foreach (DataGridViewRow row in SelectedTests)
            {
                if (row.Cells["typeDataGridViewTextBoxColumn"].Value.ToString() == "L")
                {
                    LaboratoryTest newTest = new LaboratoryTest();
                    newTest.Code = row.Cells[0].Value.ToString();
                    newTest.DoctorNotes = "Zieloni pięćset";
                    newTest.ComissionDate = DateTime.Now;
                    newTest.Status = TestStatus.Scheduled.ToCode();
                    newTest.ManagerNotes = "Żółci tysiąc";
                    newTest.IdVisit = long.Parse(Row.Cells["visitIdDataGridViewTextBoxColumn"].Value.ToString());
                    TestService.Add(newTest);
                }
                else
                {
                    PhysicalTest newTest = new PhysicalTest();
                    newTest.Code = row.Cells[0].Value.ToString();
                    newTest.Result = "Not filled yet";
                    newTest.IdVisit = long.Parse(Row.Cells["visitIdDataGridViewTextBoxColumn"].Value.ToString());
                    TestService.Add(newTest);
                }
                testamountadded++;
            }

            MessageBox.Show("Added " + testamountadded + " tests.");

            //DataGridViewSelectedRowCollection selectedTests = dataGridTestDictionary.SelectedRows;
            //foreach (DataGridViewRow row in selectedTests)
            //{
            //    foreach (DataGridViewRow visit in SelectedVisits)
            //    {
            //        LaboratoryTest newTest = new LaboratoryTest();
            //        newTest.Code = row.Cells[0].Value.ToString();
            //        newTest.DoctorNotes = "Zieloni pięćset";
            //        newTest.ComissionDate = DateTime.Now;
            //        newTest.Status = TestStatus.Scheduled.ToCode();
            //        newTest.ManagerNotes = "Żółci tysiąc";
            //        newTest.IdVisit = long.Parse(visit.Cells["visitIdDataGridViewTextBoxColumn"].Value.ToString());
            //        //newTest.Visit = VisitsService.GetByVisitId(newTest.IdVisit);
            //        //Console.WriteLine("Visit ID: "+newTest.IdVisit+", id through 'Visit' component: "+newTest.Visit.Id);
            //        TestService.Add(newTest);
            //        testamountadded++;
            //    }

            //}
            //MessageBox.Show("Added " + testamountadded + " tests.");
        }

        private void btnTestDetailsDoctorRefresh_Click(object sender, EventArgs e)
        {
            TestDictionaryBindingSource.Clear();
            TestDictionaryBindingSource.AddRange(TestService.GetDictionary());
            ScheduledTestsBindingSource.Clear();
            ScheduledTestsBindingSource.AddRange(TestService.GetTestsOfStatus(TestStatus.Scheduled, SelectedVisitId));
            ApprovedTestsBindingSource.Clear();
            ApprovedTestsBindingSource.AddRange(TestService.GetTestsOfStatus(TestStatus.Approved, SelectedVisitId));
            PhysicalTestBindingSource.Clear();
            PhysicalTestBindingSource.AddRange(TestService.GetPhysicalTests(SelectedVisitId));
            MessageBox.Show("All data refreshed!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPhysicalTests.Columns.IndexOf(btnEditPhysicalTest) == e.ColumnIndex)
            {
                MessageBox.Show(":P");
            }
        }
    }
}
