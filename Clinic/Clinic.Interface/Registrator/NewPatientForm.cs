using System;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class NewPatientForm : Form
    {
        public NewPatientForm()
        {
            InitializeComponent();
            doneCancelDialog.Cancel += Cancel;
        }

        private void Cancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
