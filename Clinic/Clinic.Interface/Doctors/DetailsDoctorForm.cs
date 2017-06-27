using Clinic.Data;
using Clinic.Facades.Patients;
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
        //private int StatusColumnIndex; TODO refactor
        Visit SelectedVisit;
        Patient SelectedPatient;

        public DetailsDoctorForm(System.Windows.Forms.DataGridView datGridVisits)
        {
            InitializeComponent();
            SelectedVisits = datGridVisits.SelectedRows;
            
            long SelectedVisitId = (long.Parse(SelectedVisits[0].Cells["visitIdDataGridViewTextBoxColumn"].Value.ToString()));
            SelectedVisit = VisitsService.GetVisitById(SelectedVisitId);
            SelectedPatient = PatientsService.GetPatientById(SelectedVisit.IdPatient);
            txtBoxDetailsDescription.MaximumSize = grpBoxDetailsDescription.Size;
            //txtBoxDetailsDiagnosis.MaximumSize = grpBoxDetailsDoctorDiagnosis.Size;

            lblDetailsVisitDate.Text = SelectedVisit.PlannedDate.ToString();
            lblDetailsPatientName.Text = "Name:      "+ SelectedPatient.Name;
            lblDetailsPatientSurname.Text = "Surname: "+ SelectedPatient.Surname;
            lblDetailsPatientPESEL.Text = "PESEL:   "+ SelectedPatient.PESEL;
            if ((SelectedVisit.Description == "") || (SelectedVisit.Description == null))
            {
                txtBoxDetailsDescription.Text = "Empty";
            }
            else
            {
                txtBoxDetailsDescription.Text = SelectedVisit.Description;
            }

            if ((SelectedVisit.Diagnosis == "") || (SelectedVisit.Diagnosis == null))
            {
                txtBoxDetailsDiagnosis.Text = "Empty";
            }
            else
            {
                txtBoxDetailsDiagnosis.Text = SelectedVisit.Diagnosis;
            }
        }

        private void btnDoctorReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTestDetails_Click(object sender, EventArgs e)
        {
            var TestDetailsForm = new TestDetailsDoctorForm(SelectedVisits[0]);
            TestDetailsForm.ShowDialog(ActiveUser);
        }

        private void Save_Diagnosis()
        {
            SelectedVisit.Diagnosis = txtBoxDetailsDiagnosis.Text;
            SelectedVisit.Description = txtBoxDetailsDescription.Text;
            VisitsService.Update(SelectedVisit);
            this.Close();
        }

        private void DetailsDoctorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //todo fancy refactor usaved data
            //DialogResult temp = MessageBox.Show(
            //    this,
            //    "You are about to exit this window, but there are unsaved changes. Do you want to save the changes?",
            //    "Unsaved data",
            //    System.Windows.Forms.MessageBoxButtons.YesNo,
            //    System.Windows.Forms.MessageBoxIcon.Warning
            //    );
            //if (temp == DialogResult.Yes)
            //{
            //    Save_Diagnosis();
            //    this.Close();
            //}
            //else
            //{
            //    this.Close();
            //}
        }

        private void btnSaveDiagnosis_Click(object sender, EventArgs e)
        {
            Save_Diagnosis();
        }
    }
}
