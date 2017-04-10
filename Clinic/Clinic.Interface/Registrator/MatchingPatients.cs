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
            var form = new NewPatientForm(labelledInputFirstName.Input, labelledInputLastName.Input, labelledInputEvidenceNumber.Input);
            form.ShowDialog();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelledInputFirstName.Input = "";
            labelledInputLastName.Input = "";
            labelledInputEvidenceNumber.Input = "";
        }
    }
}
