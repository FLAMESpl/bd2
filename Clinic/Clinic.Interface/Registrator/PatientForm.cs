using Clinic.Data;
using Clinic.Facades.Common;
using Clinic.Facades.Patients;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class PatientForm : ClinicForm
    {
        private ActionType actionType;
        private Patient patient;

        public PatientForm()
        {
            InitializeComponent();
            SetupComponent();
        }

        public PatientForm(Patient patient, ActionType actionType)
        {
            InitializeComponent();
            this.actionType = actionType;
            this.patient = patient;
            SetupComponent();

            labelledInputFirstName.Input = patient.Name;
            labelledInputLastName.Input = patient.Surname;
            labelledInputEvidenceNumber.Input = patient.PESEL;

            if (actionType == ActionType.Update)
                SetupAddresses();
        }

        private void SetupAddresses()
        {
            bindingSourceAddresses.AddRange(patient.Addresses.OrderBy(x => x.IsValid));
        }

        private void SetupComponent()
        {
            doneCancelDialog.Cancel += Cancel;
            doneCancelDialog.Done += Done;
            addressFilters.AddButtonEnabled = (actionType == ActionType.Update);
            if (actionType == ActionType.Update)
            {
                Height += 250;
            }
            else
            {
                dataGridViewAddresses.Enabled = false;
                dataGridViewAddresses.Visible = false;
            }
        }

        private void CreatePatient()
        {
            patient.Name = labelledInputFirstName.Input;
            patient.PESEL = labelledInputEvidenceNumber.Input;
            patient.Surname = labelledInputLastName.Input;
            patient.Addresses.Add(addressFilters.GetAddress());

            PatientsService.Add(patient);
        }

        private void UpdatePatient()
        {
            patient.Name = labelledInputFirstName.Input;
            patient.PESEL = labelledInputEvidenceNumber.Input;
            patient.Surname = labelledInputLastName.Input;
            patient.Addresses.AddRange(bindingSourceAddresses.Cast<Address>());

            PatientsService.Update(patient);
        }

        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void Done(object sender, EventArgs e)
        {
            try
            {
                switch (actionType)
                {
                    case ActionType.Create:
                        CreatePatient();
                        Messages.EntityCreated("Patient");
                        Close();
                        break;
                    case ActionType.Update:
                        UpdatePatient();
                        Messages.EntityUpdated("Patient");
                        Close();
                        break;
                    default:
                        break;
                }
            }
            catch (DomainException ex)
            {
                ex.ShowMessage();
            }
        }

        private void addressFilters_AddressAdded(object sender, EventArgs e)
        {
            foreach (var addr in bindingSourceAddresses.Cast<Address>())
                addr.IsValid = false;

            bindingSourceAddresses.List.Insert(0, addressFilters.GetAddress());
        }
    }
}
