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
        //sprivate int StatusColumnIndex; TODO refactor
        Visit SelectedVisit;
        Patient SelectedPatient;

        public DetailsDoctorForm(System.Windows.Forms.DataGridView datGridVisits)
        {
            InitializeComponent();
            SelectedVisits = datGridVisits.SelectedRows;

            string exampleString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.Maecenas ultricies magna et ipsum ullamcorper, quis consequat lorem pulvinar.Donec laoreet, dui sed ultrices feugiat, dui quam sagittis felis, sit amet sollicitudin elit felis ut nisi. Nulla ante nunc, efficitur non posuere vitae, imperdiet sit amet odio.Aliquam erat volutpat.Proin aliquam dictum mi, at viverra orci aliquet id. Cras vulputate ornare arcu in suscipit.Nullam ullamcorper magna ut odio placerat, ac posuere magna efficitur.\nDonec aliquet augue eu convallis ornare. Phasellus porta id nulla a rutrum. Donec purus lorem, venenatis eget tellus in, finibus pretium purus.Aliquam aliquet sem a finibus viverra. Vestibulum gravida orci tortor, non laoreet turpis sollicitudin sed. Vivamus dapibus nisl in augue cursus, ut congue urna aliquet.Pellentesque vestibulum nibh ligula, ac accumsan est porta sit amet.Sed fringilla tellus in magna vehicula lobortis.Sed nec enim aliquam, auctor elit quis, egestas nisl.Maecenas quis fermentum est, sed semper sapien. Nam bibendum auctor gravida. In ut ante at dui cursus ullamcorper.In egestas elit dolor, a mattis velit scelerisque rutrum. Ut eget mattis augue. In rutrum magna nisl, eu venenatis ipsum aliquet vitae. Nam nibh metus, vestibulum nec ex et, lobortis aliquet ante. Aenean at tortor. ";
            long SelectedVisitId = (long.Parse(SelectedVisits[0].Cells["visitIdDataGridViewTextBoxColumn"].Value.ToString()));
            SelectedVisit = VisitsService.GetVisitById(SelectedVisitId);
            Patient Marek = PatientsService.GetPatientById(SelectedVisit.IdPatient);
            txtBoxDetailsDescription.MaximumSize = grpBoxDetailsDescription.Size;
            //txtBoxDetailsDiagnosis.MaximumSize = grpBoxDetailsDoctorDiagnosis.Size;

            lblDetailsVisitDate.Text = SelectedVisit.PlannedDate.ToString();
            lblDetailsPatientName.Text = "Name:      "+Marek.Name;
            lblDetailsPatientSurname.Text = "Surname: "+Marek.Surname;
            lblDetailsPatientPESEL.Text = "PESEL:   "+Marek.PESEL;
            if ((SelectedVisit.Description == "") || (SelectedVisit.Description == null))
            {
                txtBoxDetailsDescription.Text = exampleString;// "No data";
            }
            else
            {
                txtBoxDetailsDescription.Text = SelectedVisit.Description;
            }

            if ((SelectedVisit.Diagnosis == "") || (SelectedVisit.Diagnosis == null))
            {
                txtBoxDetailsDiagnosis.Text = exampleString;// "No data";
            }
            else
            {
                txtBoxDetailsDiagnosis.Text = SelectedVisit.Diagnosis;
            }


            //StatusColumnIndex = datGridVisits.Columns["statusDataGridViewTextBoxColumn"].Index;
            //int gridindex = 0;
            //foreach (System.Windows.Forms.DataGridViewRow row in SelectedVisits)
            //{
            //    this.DatGridDetailsSelectedRows.Rows.Insert(gridindex, SelectedVisits);
            //    gridindex++;
            //}

            //var testyZeSlownika = TestService.GetDictionary(); //UsersService.Match(userFilters.GetUser());
            //testDictionaryBindingSource.Clear();
            //testDictionaryBindingSource.DataSource = testyZeSlownika;
            //testDictionaryBindingSource.AddRange(testyZeSlownika.Select(x => x));
        }

        private void RefreshDetailsData()
        {

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

        private void btnDoctorReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DetailsDoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet.TestDictionary' table. You can move, or remove it, as needed.
           //this.testDictionaryTableAdapter.Fill(this.clinicDataSet.TestDictionary);

        }

        private void btnDetailsPhysicalTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show(":)");
        }

        private void btnTestDetails_Click(object sender, EventArgs e)
        {
            var TestDetailsForm = new TestDetailsDoctorForm(SelectedVisits[0]);
            TestDetailsForm.ShowDialog(ActiveUser);
        }

        private void Save_Diagnosis()
        {
            SelectedVisit.Diagnosis = txtBoxDetailsDiagnosis.Text;
            VisitsService.Update(SelectedVisit);
            MessageBox.Show("Diagnosis saved");
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
