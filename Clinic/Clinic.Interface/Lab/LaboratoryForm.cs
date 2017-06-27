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
                        
        private void LaboratoryForm_Load(object sender, EventArgs e)
        {
            comboBoxStatus.DataSource = Enum.GetValues(typeof(TestStatus));
            dataGridViewTests.AutoGenerateColumns = true;
            RefreshList();
            if (ActiveUser.Role == Role.LabAssistant.ToCode())
            {
                buttonAddTests.Visible = false;
                comboBoxStatus.SelectedItem = TestStatus.Scheduled;
                Text = "Laboratory Assistant";
            }
            else if (ActiveUser.Role == Role.LabManager.ToCode())
            {
                comboBoxStatus.SelectedItem = TestStatus.Executed;
                Text = "Laboratory Manager";
            }
        }
        private void RefreshList()
        {
            bindingSourcePatientLaboratoryTests.Clear();
            bindingSourcePatientLaboratoryTests.AddRange(TestService.MatchWithPatient(
                labelledTextBoxName.Input,
                labelledTextBoxSurname.Input,
                labelledTextBoxPESEL.Input,
                (TestStatus)comboBoxStatus.SelectedItem));
            if (ActiveUser.Role == Role.LabAssistant.ToCode())
            {
                dataGridViewTests.Columns[7].Visible = false;
                dataGridViewTests.Columns[8].Visible = false;
            }
            dataGridViewTests.Columns[0].Visible = false;
            dataGridViewTests.Refresh();
        }

        private void buttonAcceptTest_Click(object sender, EventArgs e)
        {
            if (ActiveUser.Role == Role.LabManager.ToCode())
            {
                EditTestAsManager();
            }
            else if (ActiveUser.Role == Role.LabAssistant.ToCode())
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
            labelledTextBoxName.Input = string.Empty;                
            labelledTextBoxSurname.Input = string.Empty;
            labelledTextBoxPESEL.Input = string.Empty;
            RefreshList();
        }
        
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshList();
            switch (RolesExtensions.GetFromCode(ActiveUser.Role))
            {
                case Role.LabAssistant:
                    if ((TestStatus)comboBoxStatus.SelectedItem == TestStatus.Scheduled)
                    {
                        ShowButtonAcceptTest();
                    }
                    else
                    {
                        HideButtonAcceptTest();
                    }        
                    break;
                case Role.LabManager:
                    if ((TestStatus)comboBoxStatus.SelectedItem == TestStatus.Executed)
                    {
                        ShowButtonAcceptTest();
                    }
                    else
                    {
                        HideButtonAcceptTest();
                    }
                    break;
            }
        }
        private void HideButtonAcceptTest()
        {
            buttonAcceptTest.Enabled = false;
            buttonAcceptTest.Text = "Not available - change status";
        }
        private void ShowButtonAcceptTest()
        {
            buttonAcceptTest.Enabled = true;
            buttonAcceptTest.Text = "Accept/Cancel test";
        }
    }
}
