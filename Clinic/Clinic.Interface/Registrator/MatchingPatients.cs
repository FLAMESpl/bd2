using Clinic.Data;
using Clinic.Interface.Common;
using System;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class MatchingPatients : UserControl
    {
        public MatchingPatients()
        {
            InitializeComponent();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            var form = new UpdatePatientForm(
                firstName: labelledInputFirstName.Input,
                lastName: labelledInputLastName.Input,
                evidenceNumber: labelledInputEvidenceNumber.Input);

            form.ShowDialog();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelledInputFirstName.Input = "";
            labelledInputLastName.Input = "";
            labelledInputEvidenceNumber.Input = "";
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            var form = new UpdatePatientForm(new Patient());

            form.ShowDialog();
        }
    }
}
