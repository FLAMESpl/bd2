using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.Data;

namespace Clinic.Interface.Lab
{
    public partial class TestResultsForm : Form
    {
        public string returnedValue;

        public TestResultsForm()
        {
            InitializeComponent();
        }

        private void buttonExecuteTest_Click(object sender, EventArgs e)
        {
            returnedValue = labelledTextBoxResult.Input;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
