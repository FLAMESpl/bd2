﻿using System;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class MatchingPatients : UserControl
    {
        public MatchingPatients()
        {
            InitializeComponent();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            var form = new NewPatientForm();
            form.ShowDialog();
        }
    }
}
