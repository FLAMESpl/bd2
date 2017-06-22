using System;
using Clinic.Interface.Common;
using Clinic.Data;
using Clinic.Facades.Tests;

namespace Clinic.Interface.Lab
{
    public partial class TestForm : ClinicForm
    {
        public string returnedValue;
        public bool testAccepted;

        public TestForm()
        {
            returnedValue = string.Empty;
            InitializeComponent();
        }

        private void buttonAcceptTest_Click(object sender, EventArgs e)
        {
            returnedValue = labelledTextBoxComment.Input;
            testAccepted = true;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void buttonCancelTest_Click(object sender, EventArgs e)
        {
            returnedValue = labelledTextBoxComment.Input;
            testAccepted = false;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }
    }
}
