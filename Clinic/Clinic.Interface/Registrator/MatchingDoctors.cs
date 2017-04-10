using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class MatchingDoctors : UserControl
    {
        public MatchingDoctors()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelledInputFirstName.Input = "";
            labelledInputLastName.Input = "";
        }
    }
}
