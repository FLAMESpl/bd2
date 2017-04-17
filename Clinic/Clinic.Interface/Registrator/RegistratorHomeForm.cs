using Clinic.Data;
using Clinic.Facades.Patients;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class RegistratorHomeForm : Form
    {
        public RegistratorHomeForm()
        {
            InitializeComponent();
        }

        private void EditPatient(Patient patient)
        {
            using (var form = new UpdatePatientForm(patient, ActionType.Update))
            { 
                form.ShowDialog();
            }
        }

        private void DeletePatient(Patient patient)
        {

        }

        private void AddVisit(Patient patient)
        {
            using (var form = new NewVisitForm(patient, ActionType.Create))
            {
                form.ShowDialog();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var form = new UpdatePatientForm(patientFilters.GetPatient(), ActionType.Create))
            {
                form.ShowDialog();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchCriteria = patientFilters.GetPatient();
            bindingSourcePatients.List.Clear();
            bindingSourcePatients.List.AddRange(PatientsService.Match(searchCriteria));
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
                case "Visit":
                    AddVisit((Patient)bindingSourcePatients.Current);
                    break;
            }
        }
    }
}
