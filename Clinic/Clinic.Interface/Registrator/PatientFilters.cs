using Clinic.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class PatientFilters : UserControl
    {
        public int MyProperty { get; set; }
        public List<Button> aMyProperty { get; set; }

        public PatientFilters()
        {
            InitializeComponent();
        }

        public Patient GetPatient() => new Patient
        {
            Name = labelledInputName.Input,
            Surname = labelledInputSurname.Input,
            PESEL = labelledInputPESEL.Input
        };

        public void SetPatient(Patient patient)
        {
            labelledInputName.Input = patient.Name;
            labelledInputSurname.Input = patient.Surname;
            labelledInputPESEL.Input = patient.PESEL;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelledInputName.Input = String.Empty;
            labelledInputSurname.Input = String.Empty;
            labelledInputPESEL.Input = String.Empty;
        }
    }
}
