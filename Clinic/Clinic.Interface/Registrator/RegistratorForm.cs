using Clinic.Data;
using Clinic.Facades.Patients;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
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
            using (var form = new PatientForm(patient, ActionType.Update, this))
            { 
                form.ShowDialog(ActiveUser);
            }
        }

        public void RefreshList()
        {
            var searchCriteria = patientFilters.GetPatient();
            bindingSourcePatients.List.Clear();
            bindingSourcePatients.List.AddRange(PatientsService.Match(searchCriteria));
            MessageBox.Show("List is refreshed!");
        }

        //private void DeletePatient(Patient patient)
        //{
        //    MessageBox.Show(
        //        this,
        //        "The action you chose will delete this patient permanently. There is no way to bring this data back. Are you sure?",
        //        "You are about to delete a patient!",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Warning,
        //        MessageBoxDefaultButton.Button2
        //        );
        //    if (PatientsService.Delete(patient) == 0)
        //    {
        //        MessageBox.Show(
        //            this,
        //            "Patient sucessfully deleted!",
        //            "Success!",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Information,
        //            MessageBoxDefaultButton.Button1
        //            );
        //    }
        //    else
        //    {
        //        MessageBox.Show(
        //            this,
        //            "Patient cannot be deleted.",
        //            "Failure!",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error,
        //            MessageBoxDefaultButton.Button1
        //            );
        //    }
        //    patient.Name = "DELETED";
        //    patient.Surname = "DELETED";
        //    patient.PESEL = "DELETED";
        //}

        private void AddVisit(Patient patient)
        {
            using (var form = new VisitForm(patient, ActionType.Create))
            {
                form.ShowDialog(ActiveUser);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var form = new PatientForm(patientFilters.GetPatient(), ActionType.Create, this))
            {
                form.ShowDialog(ActiveUser);
            }
            MessageBox.Show("Patient added!");
            this.patientFilters.ClearInputs();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            RefreshList();
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
            }
        }
    }
}
