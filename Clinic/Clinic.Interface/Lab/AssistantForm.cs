using Clinic.Facades.Tests;
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
    public partial class AssistantForm : Form
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
            dataGridViewTests.Columns["Code"].Visible = false;
        }
    }
}
