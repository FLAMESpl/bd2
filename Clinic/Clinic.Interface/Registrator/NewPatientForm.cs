using Clinic.Data;
using Clinic.Facades.Patients;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class NewPatientForm : Form
    {
        public NewPatientForm()
        {
            InitializeComponent();
            SetupComponent();
        }

        public NewPatientForm(string firstName, string lastName, string evidenceNumber)
        {
            InitializeComponent();
            SetupComponent();

            labelledInputFirstName.Input = firstName;
            labelledInputLastName.Input = lastName;
            labelledInputEvidenceNumber.Input = evidenceNumber;
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

        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }

        private void Done(object sender, EventArgs e)
        {
            CreatePatient();
            Close();
        }
    }
}
