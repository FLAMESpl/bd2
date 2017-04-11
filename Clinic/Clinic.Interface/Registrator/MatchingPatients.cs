using Clinic.Data;
using Clinic.Facades.Patients;
using Clinic.Interface.Common.Helpers;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class MatchingPatients : UserControl
    {
        private Timer timer = new Timer();
        private bool pendingMatching = false;

        public MatchingPatients()
        {
            InitializeComponent();

            timer.Stop();
            timer.Interval = 2000;
            timer.Tick += InactivityTimeElapsed;
        }

        public void MatchPatients()
        {
            var searchCriteria = new Patient
            {
                name = labelledInputFirstName.Input,
                surname = labelledInputLastName.Input,
            };

            bindingSourcePatients.Clear();
            foreach (var patient in PatientsService.MatchPatients(searchCriteria))
            {
                bindingSourcePatients.Add(patient);
            }
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

        private void labelledInputFirstName_InputChanged(object sender, EventArgs e)
        {
            timer.Reset();
        }

        private void labelledInputLastName_InputChanged(object sender, EventArgs e)
        {
            timer.Reset();
        }

        private void InactivityTimeElapsed(object sender, EventArgs e)
        {
            timer.Stop();
            MatchPatients();
            //Task.Run((Action)MatchPatients);
        }
    }
}
