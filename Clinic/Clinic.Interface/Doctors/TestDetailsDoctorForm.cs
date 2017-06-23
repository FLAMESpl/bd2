using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.Interface.Doctors
{
    public partial class TestDetailsDoctorForm : ClinicForm
    {
        public TestDetailsDoctorForm()
        {
            InitializeComponent();
            TestDictionaryBindingSource.Clear();
            //TestDictionaryBindingSource.AddRange();
        }

        private void btnTestDetailsDoctorReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
