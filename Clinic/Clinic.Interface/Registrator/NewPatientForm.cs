using Clinic.Data;
using Clinic.Facades.Patients;
using System;
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
                Name = labelledInputFirstName.Input,
                PESEL = int.Parse(labelledInputEvidenceNumber.Input),
                Surname = labelledInputLastName.Input
            };

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
