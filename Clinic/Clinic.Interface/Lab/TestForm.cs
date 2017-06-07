using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.Interface.Common;
using Clinic.Data;

namespace Clinic.Interface.Lab
{
    public partial class TestForm : ClinicForm
    {
        public TestForm()
        {
            InitializeComponent();
        }

        public TestForm(LaboratoryTest laboratoryTest)
        {
            InitializeComponent();
        }
    }
}
