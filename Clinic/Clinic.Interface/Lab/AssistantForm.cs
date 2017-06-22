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

namespace Clinic.Interface.Lab
{
    public partial class AssistantForm : ClinicForm
    {
        public AssistantForm()
        {
            InitializeComponent();
        }

        private void AssistantForm_Load(object sender, EventArgs e)
        {
            dataGridViewTests.DataSource = TestService.GetAllScheduled();
            dataGridViewTests.Columns["Id"].Visible = false;
            dataGridViewTests.Columns["Result"].Visible = false;
            dataGridViewTests.Columns["ExecutionDate"].Visible = false;
            dataGridViewTests.Columns["ManagerNotes"].Visible = false;
            dataGridViewTests.Columns["ResolutionDate"].Visible = false;
            dataGridViewTests.Columns["Status"].Visible = false;
            dataGridViewTests.Columns["IdLabAssistant"].Visible = false;
            dataGridViewTests.Columns["IdLabManager"].Visible = false;
            dataGridViewTests.Columns["IdVisit"].Visible = false;
        }

        private void buttonInputResults_Click(object sender, EventArgs e)
        {
            using (var form = new TestResultsForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LaboratoryTest test = new LaboratoryTest();
                    test.Id = (long)dataGridViewTests.SelectedRows[0].Cells["Id"].Value;
                    test.Result = form.returnedValue;
                    test.ExecutionDate = DateTime.Now;
                    test.Status = TestStatus.Executed.ToCode();
                    test.IdLabAssistant = ActiveUser.Id;
                    TestService.UpdateAsAssistant(test);
                }
            }
        }

        private void buttonCancelTest_Click(object sender, EventArgs e)
        {
            LaboratoryTest test = new LaboratoryTest();
            test.Id = (long)dataGridViewTests.SelectedRows[0].Cells["Id"].Value;
            test.ExecutionDate = DateTime.Now;
            test.Status = TestStatus.CancelledByAssistant.ToCode();
            test.IdLabAssistant = ActiveUser.Id;
            TestService.UpdateAsAssistant(test);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewTests.Refresh();
        }
    }
}
