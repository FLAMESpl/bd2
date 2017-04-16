using Clinic.Data;
using Clinic.Facades.Patients;
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

        public void MatchPatients()
        {
            var searchCriteria = new Patient
            {
                Name = labelledInputFirstName.Input,
                Surname = labelledInputLastName.Input,
            };

            bindingSourcePatients.Clear();
            foreach (var patient in PatientsService.Match(searchCriteria))
            {
                bindingSourcePatients.Add(patient);
            }
        }

        private void EditPatient(Patient patient)
        {
            var form = new UpdatePatientForm(patient, ActionType.Update);
            form.ShowDialog();
        }

        private void DeletePatient(Patient patient)
        {
            
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            var patient = new Patient
            {
                Name = labelledInputFirstName.Input,
                Surname = labelledInputLastName.Input,
                PESEL = labelledInputEvidenceNumber.Input
            };

            var form = new UpdatePatientForm(patient, ActionType.Create);
            form.ShowDialog();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelledInputFirstName.Input = "";
            labelledInputLastName.Input = "";
            labelledInputEvidenceNumber.Input = "";
        }

        private void buttonSearchPatients_Click(object sender, EventArgs e)
        {
            MatchPatients();
        }

        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            var columnName = grid.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "Edit":
                    EditPatient((Patient)bindingSourcePatients.Current);
                    break;
                case "Delete":
                    DeletePatient((Patient)bindingSourcePatients.Current);
                    break;
            }
        }
    }
}
