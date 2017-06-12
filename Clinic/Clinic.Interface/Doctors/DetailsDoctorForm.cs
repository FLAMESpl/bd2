using Clinic.Facades.Visits;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Linq;


namespace Clinic.Interface.Doctors
{
    public partial class DetailsDoctorForm : ClinicForm
    {
        private System.Windows.Forms.DataGridViewSelectedRowCollection SelectedVisits;
        private int StatusColumnIndex;

        public DetailsDoctorForm(System.Windows.Forms.DataGridView datGridVisits)
        {
            InitializeComponent();
            SelectedVisits = datGridVisits.SelectedRows;
            StatusColumnIndex = datGridVisits.Columns["statusDataGridViewTextBoxColumn"].Index;
            //int gridindex = 0;
            //foreach (System.Windows.Forms.DataGridViewRow row in SelectedVisits)
            //{
            //    this.DatGridDetailsSelectedRows.Rows.Insert(gridindex, SelectedVisits);
            //    gridindex++;
            //}
        }

        void NoRowsSelectedMessage()
        {
            System.Windows.Forms.MessageBox.Show(
                this,
                "You have not selected any rows. To select them, go back to the previous window and select rows on the left panel (the one with the trangular arrow).",
                "No rows selected.",
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Warning
                );            
        }

        private void btnDoctorFinalizeVisit_Click(object sender, EventArgs e)
        {
            Console.WriteLine(SelectedVisits.Count);
            if (SelectedVisits.Count != 0)
            {
                int updatedcount = 0;
                foreach (System.Windows.Forms.DataGridViewRow row in SelectedVisits)
                {
                    if (row.Cells[StatusColumnIndex].Value.ToString() == Clinic.Facades.Visits.VisitStatus.Scheduled.ToString())
                    {
                        row.Cells[StatusColumnIndex].Value = Clinic.Facades.Visits.VisitStatus.Finalised;
                        updatedcount++;
                    }
                }
                System.Windows.Forms.MessageBox.Show(updatedcount + " visit slots finalized!");
                btnDoctorReturn_Click(sender, e);
            }
            else
            {
                NoRowsSelectedMessage();
            }            

        }

        private void btnDoctorCancelVisit_Click(object sender, EventArgs e)
        {
            if (SelectedVisits.Count != 0)
            {
                int updatedcount = 0;
                foreach (System.Windows.Forms.DataGridViewRow row in SelectedVisits)
                {
                    if (row.Cells[StatusColumnIndex].Value.ToString() == Clinic.Facades.Visits.VisitStatus.Scheduled.ToString())
                    {
                        row.Cells[StatusColumnIndex].Value = Clinic.Facades.Visits.VisitStatus.Cancelled;
                        updatedcount++;
                    }
                }
                System.Windows.Forms.MessageBox.Show(updatedcount + " visit slots cancelled!");
                btnDoctorReturn_Click(sender, e);
            }
            else
            {
                NoRowsSelectedMessage();
            }

        }

        private void btnDoctorReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
