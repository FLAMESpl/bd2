using System;
using Clinic.Interface.Common;
using Clinic.Data;
using Clinic.Facades.Tests;

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
            test.Status = TestStatus.Approved.ToCode();
            test.ManagerNotes = labelledTextBoxComment.Input;
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancelTest_Click(object sender, EventArgs e)
        {
            test.Status = TestStatus.CancelledByManager.ToCode();
            test.ManagerNotes = labelledTextBoxComment.Input;
            Close();
        }
    }
}
