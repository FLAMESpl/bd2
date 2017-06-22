using Clinic.Data;
using Clinic.Facades.Tests;
using Clinic.Facades.Visits;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.Interface.Doctors
{
    public partial class DetailsDoctorForm : ClinicForm
    {
        private System.Windows.Forms.DataGridViewSelectedRowCollection SelectedVisits;
        private int StatusColumnIndex;

        public DetailsDoctorForm(System.Windows.Forms.DataGridView datGridVisits)
        {
            //dataGridTestDictionary.c = TestService.GetDictionary();

            InitializeComponent();
            SelectedVisits = datGridVisits.SelectedRows;
            StatusColumnIndex = datGridVisits.Columns["statusDataGridViewTextBoxColumn"].Index;
            //int gridindex = 0;
            //foreach (System.Windows.Forms.DataGridViewRow row in SelectedVisits)
            //{
            //    this.DatGridDetailsSelectedRows.Rows.Insert(gridindex, SelectedVisits);
            //    gridindex++;
            //}

            var testyZeSlownika = TestService.GetDictionary(); //UsersService.Match(userFilters.GetUser());
            //testDictionaryBindingSource.Clear();
            testDictionaryBindingSource.DataSource = testyZeSlownika;
            //testDictionaryBindingSource.AddRange(testyZeSlownika.Select(x => x));
        }

        void NoRowsSelectedMessage()
        {
            System.Windows.Forms.MessageBox.Show(
                this,
                "You have not selected any rows. To select them, go back to the previous window and select rows on the left panel (the one with the triangular arrow).",
                "No rows selected.",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Warning
                );            
        }

        private void btnDoctorFinalizeVisit_Click(object sender, EventArgs e)
        {
            Console.WriteLine(SelectedVisits.Count);
            if (SelectedVisits.Count != 0)
            {
                int updatedcount = 0;
                foreach (System.Windows.Forms.DataGridViewRow row in SelectedVisits)
                {
                    if (row.Cells[StatusColumnIndex].Value.ToString() == Clinic.Facades.Visits.VisitStatus.Scheduled.ToString())
                    {
                        row.Cells[StatusColumnIndex].Value = Clinic.Facades.Visits.VisitStatus.Finalised;
                        updatedcount++;
                    }
                }
                System.Windows.Forms.MessageBox.Show(updatedcount + " visit slots finalized!");
                btnDoctorReturn_Click(sender, e);
            }
            else
            {
                NoRowsSelectedMessage();
            }            

        }

        private void btnDoctorCancelVisit_Click(object sender, EventArgs e)
        {
            if (SelectedVisits.Count != 0)
            {
                int updatedcount = 0;
                foreach (System.Windows.Forms.DataGridViewRow row in SelectedVisits)
                {
                    if (row.Cells[StatusColumnIndex].Value.ToString() == Clinic.Facades.Visits.VisitStatus.Scheduled.ToString())
                    {
                        row.Cells[StatusColumnIndex].Value = Clinic.Facades.Visits.VisitStatus.Cancelled;
                        updatedcount++;
                    }
                }
                System.Windows.Forms.MessageBox.Show(updatedcount + " visit slots cancelled!");
                btnDoctorReturn_Click(sender, e);
            }
            else
            {
                NoRowsSelectedMessage();
            }

        }

        private void btnDoctorReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoctorAssignLabTest(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedTests = dataGridTestDictionary.SelectedRows;
            int testamountadded = 0;
            foreach (DataGridViewRow row in selectedTests)
            {
                LaboratoryTest newTest = new LaboratoryTest();
                newTest.Code = row.Cells[0].Value.ToString();
                newTest.DoctorNotes = "Zieloni pięćset";
                newTest.ComissionDate = DateTime.Now;
                newTest.Status = TestStatus.Scheduled.ToCode();
                newTest.ManagerNotes = "Żółci tysiąc";
                newTest.IdVisit = 10L;
                TestService.Add(newTest);
                testamountadded++;
            }
            MessageBox.Show("Added "+testamountadded+" tests.");
        }

        private void DetailsDoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet.TestDictionary' table. You can move, or remove it, as needed.
           //this.testDictionaryTableAdapter.Fill(this.clinicDataSet.TestDictionary);

        }
    }
}
