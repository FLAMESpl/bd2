using System;
using System.Windows.Forms;
using Clinic.Interface.Common;

namespace Clinic.Interface.Lab
{
    public partial class TestResultsForm : ClinicForm
    {
        public string returnedValue;

        public TestResultsForm()
        {
            InitializeComponent();
        }

        private void buttonExecuteTest_Click(object sender, EventArgs e)
        {
            returnedValue = labelledTextBoxResult.Input;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
