using System.Windows.Forms;
using Clinic.Data;

namespace Clinic.Interface.Registrator
{
    public partial class PatientFilters : UserControl
    {
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
    }
}
