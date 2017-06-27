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

namespace Clinic.Interface.Lab
{
    public partial class EditDictionaryForm : Form
    {
        public TestDictionary td;
        public ActionType at;

        public EditDictionaryForm(ActionType actionType, TestDictionary testDictionary)
        {
            td = testDictionary;
            at = actionType;
            InitializeComponent();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            td.Code = labelledTextBoxCode.Input;
            td.Name = labelledTextBoxName.Input;
            if (radioButtonLaboratory.Checked)
                td.Type = TestType.Laboratory.ToCode();
            else
                td.Type = TestType.Physical.ToCode();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditDictionaryForm_Load(object sender, EventArgs e)
        {
            labelledTextBoxCode.Input = td.Code;
            labelledTextBoxName.Input = td.Name;
            if (TestTypeExtensions.GetFromCode(td.Type) == TestType.Laboratory)
                radioButtonLaboratory.Checked = true;
            else
                radioButtonPhysical.Checked = true;
            if (at == ActionType.Update)
            {
                radioButtonLaboratory.Enabled = false;
                radioButtonPhysical.Enabled = false;
                labelledTextBoxCode.Enabled = false;
            }            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
