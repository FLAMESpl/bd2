using Clinic.Data;
using Clinic.Facades.Tests;
using Clinic.Interface.Common;
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
    public partial class EditTextDetailsForm : ClinicForm
    {
        enum TypeOfTextToEdit
        {
            PhysicalResult,
            LaboratoryComment
        }

        DataGridViewRow Row;
        TypeOfTextToEdit Workmode;
        

        public EditTextDetailsForm(DataGridViewRow row, PhysicalTest testParameter)
        {
            InitializeComponent();
            Row = row;
            InitResultText(Row.Cells["resultDataGridViewTextBoxColumn2"].Value.ToString());
            Workmode = TypeOfTextToEdit.PhysicalResult;
            grpBoxTextBox.Text = "Test result:";
        }

        public EditTextDetailsForm(DataGridViewRow row, LaboratoryTest testParameter)
        {
            InitializeComponent();
            Row = row;
            InitResultText(Row.Cells["doctorNotesDataGridViewTextBoxColumn"].Value.ToString());
            Workmode = TypeOfTextToEdit.LaboratoryComment;
            grpBoxTextBox.Text = "Doctor notes:";
        }

        public void InitResultText(string previousResult)
        {
            txtBoxEdit.Text = previousResult;
        }

        private void btnPhysicalTestResultCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPhysicalTestResultSave_Click(object sender, EventArgs e)
        {
            switch (Workmode)
            {
                case TypeOfTextToEdit.PhysicalResult:
                    PhysicalTest physicalTest = new PhysicalTest();
                    physicalTest.Id = long.Parse(Row.Cells["idDataGridViewTextBoxColumn2"].Value.ToString());
                    physicalTest.Result = txtBoxEdit.Text;
                    TestService.UpdatePhysicalTest(physicalTest);
                    break;
                case TypeOfTextToEdit.LaboratoryComment:
                    LaboratoryTest laboratoryTest = new LaboratoryTest();
                    laboratoryTest.Id = long.Parse(Row.Cells["idDataGridViewTextBoxColumn1"].Value.ToString());
                    laboratoryTest.DoctorNotes = txtBoxEdit.Text;
                    TestService.UpdateLaboratoryTestAsDoctor(laboratoryTest);
                    break;
                default:
                    break;
            }

            MessageBox.Show("Test result updated!");
        }
    }
}
