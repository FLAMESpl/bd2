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

        private void RefreshTable()
        {
            var executed = TestService.GetAllScheduled();
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            RefreshTable();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
