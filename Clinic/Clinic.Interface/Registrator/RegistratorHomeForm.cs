﻿using Clinic.Data;
using Clinic.Interface.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class RegistratorHomeForm : Form
    {
        public RegistratorHomeForm()
        {
            InitializeComponent();
        }

        private void buttonAddVisit_Click(object sender, EventArgs e)
        {
            var patient = new Patient();
            patient.Name = "Jan";
            patient.Surname = "Kowalski";
            var form = new NewVisitForm(patient, ActionType.Create);
            form.ShowDialog();
        }
    }
}
