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

namespace Clinic.Interface.Lab
{
    public partial class TestForm : ClinicForm
    {
        private LaboratoryTest test;

        public TestForm()
        {
            InitializeComponent();
        }

        public TestForm(LaboratoryTest laboratoryTest)
        {
            test = laboratoryTest;
            InitializeComponent();
        }

        private void buttonAcceptTest_Click(object sender, EventArgs e)
        {
            test.Status = "ACCEPTED";
            test.ManagerNotes = labelledTextBoxComment.Input;
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancelTest_Click(object sender, EventArgs e)
        {
            test.Status = "CANCELLED";
            test.ManagerNotes = labelledTextBoxComment.Input;
            Close();
        }
    }
}
