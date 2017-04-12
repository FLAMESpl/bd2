using Clinic.Data;
using Clinic.Facades.Patients;
using Clinic.Interface.Common;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class UpdatePatientForm : Form
    {
        private ActionType actionType;

        public UpdatePatientForm()
        {
            InitializeComponent();
            SetupComponent();
        }

        public UpdatePatientForm(string firstName, string lastName, string evidenceNumber)
        {
            InitializeComponent();
            SetupComponent();

            labelledInputFirstName.Input = firstName;
            labelledInputLastName.Input = lastName;
            labelledInputEvidenceNumber.Input = evidenceNumber;

            actionType = ActionType.Create;
        }

        public UpdatePatientForm(Patient patient)
        {
            InitializeComponent();
            SetupComponent();

            labelledInputFirstName.Input = patient.name;
            labelledInputLastName.Input = patient.surname;
            labelledInputEvidenceNumber.Input = patient.PESEL.ToString();

            actionType = ActionType.Update;
        }

        private void SetupComponent()
        {
            doneCancelDialog.Cancel += Cancel;
            doneCancelDialog.Done += Done;
        }

        private void CreatePatient()
        {
            var patient = new Patient
            {
                name = labelledInputFirstName.Input,
                PESEL = int.Parse(labelledInputEvidenceNumber.Input),
                surname = labelledInputLastName.Input
            };

            patient.Addresses.AddRange(bindingSourceAddresses.List.Cast<Address>());
            PatientsService.AddPatient(patient);
        }

        private void UpdatePatient()
        {

        }

        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void Done(object sender, EventArgs e)
        {
            switch (actionType)
            {
                case ActionType.Create:
                    CreatePatient();
                    break;
                case ActionType.Update:
                    UpdatePatient();
                    break;
                default:
                    break;
            }

            Close();
        }
    }
}
