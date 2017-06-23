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
                dataGridViewTests.DataSource = TestService.GetAllExecuted();
            }
            else    //lab assistant
            {
                dataGridViewTests.DataSource = TestService.GetAllScheduled();
                dataGridViewTests.Columns["Result"].Visible = false;
                dataGridViewTests.Columns["ExecutionDate"].Visible = false;
            }
            dataGridViewTests.Columns["Id"].Visible = false;
            dataGridViewTests.Columns["ManagerNotes"].Visible = false;
            dataGridViewTests.Columns["ResolutionDate"].Visible = false;
            dataGridViewTests.Columns["Status"].Visible = false;
            dataGridViewTests.Columns["IdLabAssistant"].Visible = false;
            dataGridViewTests.Columns["IdLabManager"].Visible = false;
            dataGridViewTests.Columns["IdVisit"].Visible = false;
            dataGridViewTests.Columns["Visit"].Visible = false;
            dataGridViewTests.Columns["TestDictionary"].Visible = false;
            dataGridViewTests.Columns["LabAssistant"].Visible = false;
            dataGridViewTests.Refresh();
        }

        private void LaboratoryForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
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
                    test.Id = (long)dataGridViewTests.SelectedRows[0].Cells["Id"].Value;
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
                    test.Id = (long)dataGridViewTests.SelectedRows[0].Cells["Id"].Value;
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
    }
}
