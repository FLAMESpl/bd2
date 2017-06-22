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

namespace Clinic.Interface.LabManager
{
    public partial class ManagerForm : ClinicForm
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            dataGridViewTests.DataSource = TestService.GetAllExecuted();
            dataGridViewTests.Columns["Id"].Visible = false;
            dataGridViewTests.Columns["ManagerNotes"].Visible = false;
            dataGridViewTests.Columns["ResolutionDate"].Visible = false;
            dataGridViewTests.Columns["Status"].Visible = false;
            dataGridViewTests.Columns["IdLabAssistant"].Visible = false;
            dataGridViewTests.Columns["IdLabManager"].Visible = false;
            dataGridViewTests.Columns["IdVisit"].Visible = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewTests.Refresh();
        }

        private void buttonAcceptTest_Click(object sender, EventArgs e)
        {
            using (var form = new TestForm())
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
                }
            }
        }
    }
}
