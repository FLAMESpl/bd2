using Clinic.Data;
using Clinic.Facades.Tests;
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

namespace Clinic.Interface.Doctors
{
    public partial class EditTextDetailsForm : ClinicForm
    {
        DataGridViewRow Row;

        public EditTextDetailsForm(DataGridViewRow row)
        {
            InitializeComponent();
            Row = row;
            InitResultText(Row.Cells["resultDataGridViewTextBoxColumn2"].Value.ToString());
        }

        public void InitResultText(string previousResult)
        {
            txtBoxPhysicalResult.Text = previousResult;
        }

        private void btnPhysicalTestResultCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPhysicalTestResultSave_Click(object sender, EventArgs e)
        {
            PhysicalTest test = new PhysicalTest();
            test.Id = long.Parse(Row.Cells["idDataGridViewTextBoxColumn2"].Value.ToString());
            test.Code = Row.Cells["codeDataGridViewTextBoxColumn3"].Value.ToString();
            test.Result = txtBoxPhysicalResult.Text;
            TestService.UpdatePhysicalTest(test);
            MessageBox.Show("Test result updated!");
        }
    }
}
