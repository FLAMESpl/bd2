using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.Interface.Common;
using Clinic.Data;
using Clinic.Interface.Lab;
using Clinic.Facades.Tests;
using Clinic.Facades.Users;
using Clinic.Interface.Common.Helpers;

namespace Clinic.Interface.LabManager
{
    public partial class LaboratoryForm : ClinicForm
    {
        public LaboratoryForm()
        {
            InitializeComponent();
        }

        private void RefreshList()
        {
            if (ActiveUser.Role == Role.LabManager.ToCode())
            {
                bindingSourcePatientLaboratoryTests.Clear();
                bindingSourcePatientLaboratoryTests.AddRange(TestService.MatchWithPatient(labelledTextBoxName.Input, labelledTextBoxSurname.Input, TestStatus.Executed));
            }
            else    //lab assistant
            {
                bindingSourcePatientLaboratoryTests.Clear();
                bindingSourcePatientLaboratoryTests.AddRange(TestService.MatchWithPatient(labelledTextBoxName.Input, labelledTextBoxSurname.Input, TestStatus.Scheduled));
                dataGridViewTests.Columns[6].Visible = false;
                dataGridViewTests.Columns[7].Visible = false;
            }
            dataGridViewTests.Columns[0].Visible = false;
            dataGridViewTests.Refresh();
        }

        private void LaboratoryForm_Load(object sender, EventArgs e)
        {
            dataGridViewTests.AutoGenerateColumns = true;
            RefreshList();
            if (ActiveUser.Role == Role.LabAssistant.ToCode())
            {
                buttonAddTests.Enabled = false;
            }
        }

        private void buttonAcceptTest_Click(object sender, EventArgs e)
        {
            if (ActiveUser.Role == Role.LabManager.ToCode())
            {
                EditTestAsManager();
            }
            else
            {
                EditTestAsAssistant();
            }
        }

        private void EditTestAsManager()
        {
            using (var form = new TestForm("Manager commentary:"))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LaboratoryTest test = new LaboratoryTest();
                    test.Id = (long)dataGridViewTests.SelectedRows[0].Cells[0].Value;
                    if (form.testAccepted)
                        test.Status = TestStatus.Approved.ToCode();
                    else
                        test.Status = TestStatus.CancelledByManager.ToCode();
                    test.ManagerNotes = form.returnedValue;
                    test.ResolutionDate = DateTime.Now;
                    test.IdLabManager = ActiveUser.Id;
                    TestService.UpdateAsManager(test);
                    RefreshList();
                }
            }
        }

        private void EditTestAsAssistant()
        {
            using (var form = new TestForm("Test result / reason of cancellation:"))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LaboratoryTest test = new LaboratoryTest();
                    test.Id = (long)dataGridViewTests.SelectedRows[0].Cells[0].Value;
                    if (form.testAccepted)
                        test.Status = TestStatus.Executed.ToCode();
                    else
                        test.Status = TestStatus.CancelledByAssistant.ToCode();
                    test.Result = form.returnedValue;
                    test.ExecutionDate = DateTime.Now;
                    test.IdLabAssistant = ActiveUser.Id;
                    TestService.UpdateAsAssistant(test);
                    RefreshList();
                }
            }
        }

        private void buttonAddTests_Click(object sender, EventArgs e)
        {
            var form = new TestDictionaryForm();
            form.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelledTextBoxName.Input = "";
            labelledTextBoxSurname.Input = "";
            RefreshList();
        }
    }
}
