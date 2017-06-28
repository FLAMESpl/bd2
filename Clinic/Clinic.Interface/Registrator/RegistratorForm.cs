using Clinic.Data;
using Clinic.Facades.Patients;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class RegistratorForm : ClinicForm
    {
        public RegistratorForm()
        {
            InitializeComponent();
        }

        private void EditPatient(Patient patient)
        {
            using (var form = new PatientForm(patient, ActionType.Update))
            { 
                form.ShowDialog(ActiveUser);
            }
        }

        private void AddVisit(Patient patient)
        {
            using (var form = new VisitForm(patient, ActionType.Create))
            {
                form.ShowDialog(ActiveUser);
            }
        }

        private void ViewPatient(Patient patient)
        {
            var addr = patient.Addresses.Single(a => a.IsValid);
            var addrLine = $"{addr.City} {addr.Street} {addr.HouseNumber}/{addr.FlatNumber}";

            using (var form = new PatientForm(patient, ActionType.Browse))
            {
                form.ShowDialog(ActiveUser);
            }
            //MessageBox.Show(addrLine, "Addresses", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var form = new PatientForm(patientFilters.GetPatient(), ActionType.Create))
            {
                form.ShowDialog(ActiveUser);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchCriteria = patientFilters.GetPatient();
            bindingSourcePatients.List.Clear();
            bindingSourcePatients.List.AddRange(PatientsService.Match(searchCriteria));
        }

        private void buttonSearchAndUpdate_Click(object sender, EventArgs e)
        {
            using (var form = new VisitForm(null, ActionType.Browse))
            {
                form.ShowDialog(ActiveUser);
            }
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
                case "Visit":
                    AddVisit((Patient)bindingSourcePatients.Current);
                    break;
                case "View":
                    ViewPatient((Patient)bindingSourcePatients.Current);
                    break;
            }
        }
    }
}
