using Clinic.Data;
using Clinic.Facades.Tests;
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
    public partial class TestDictionaryForm : Form
    {
        public TestDictionaryForm()
        {
            InitializeComponent();
        }

        private void TestDictionaryForm_Load(object sender, EventArgs e)
        {
            SearchForTests();
            dataGridViewTests.Columns["Type"].Width = 60;
            dataGridViewTests.Columns["Code"].Width = 60;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelledTextBoxCode.Input = "";
            labelledTextBoxName.Input = "";
            SearchForTests();
        }

        private void SearchForTests()
        {
            TestDictionary td = new TestDictionary();
            td.Code = labelledTextBoxCode.Input;
            td.Name = labelledTextBoxName.Input;
            if (radioButtonLaboratory.Checked)
                td.Type = TestType.Laboratory.ToCode();
            else
                td.Type = TestType.Physical.ToCode();
            dataGridViewTests.DataSource = TestService.Match(td);
            dataGridViewTests.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            TestDictionary td = new TestDictionary();
            td.Code = labelledTextBoxCode.Input;
            td.Name = labelledTextBoxName.Input;
            if (radioButtonLaboratory.Checked)
                td.Type = TestType.Laboratory.ToCode();
            else
                td.Type = TestType.Physical.ToCode();
            TestService.Add(td);
            MessageBox.Show("Test added to dictionary.", "Test added");
            SearchForTests();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForTests();
        }

        private void radioButtonPhysical_CheckedChanged(object sender, EventArgs e)
        {
            SearchForTests();
        }
    }
}
