using Clinic.Data;
using Clinic.Facades.Patients;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Data.Linq;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class UpdatePatientForm : Form
    {
        private ActionType actionType;
        private Patient patient;

        public UpdatePatientForm()
        {
            InitializeComponent();
            SetupComponent();
        }

        public UpdatePatientForm(Patient patient, ActionType actionType)
        {
            InitializeComponent();
            SetupComponent();

            this.actionType = actionType;
            this.patient = patient;
            labelledInputFirstName.Input = patient.name;
            labelledInputLastName.Input = patient.surname;
            labelledInputEvidenceNumber.Input = patient.PESEL.ToString();
            bindingSourceAddresses.AddRange(patient.Addresses);
        }

        private void SetupComponent()
        {
            doneCancelDialog.Cancel += Cancel;
            doneCancelDialog.Done += Done;
        }

        private void CreatePatient()
        {
            patient.name = labelledInputFirstName.Input;
            patient.PESEL = int.Parse(labelledInputEvidenceNumber.Input);
            patient.surname = labelledInputLastName.Input;
            patient.Addresses.AddRange(bindingSourceAddresses.List.Cast<Address>());

            PatientsService.Add(patient);
        }

        private void UpdatePatient()
        {
            patient.name = labelledInputFirstName.Input;
            patient.PESEL = int.Parse(labelledInputEvidenceNumber.Input);
            patient.surname = labelledInputLastName.Input;
            patient.Addresses.Clear();
            patient.Addresses.AddRange(bindingSourceAddresses.List.Cast<Address>());

            PatientsService.Update(patient);
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
