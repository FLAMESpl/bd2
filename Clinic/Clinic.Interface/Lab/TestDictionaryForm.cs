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
            dataGridViewTests.DataSource = TestService.Match(FilterTestDictionary());
            dataGridViewTests.Refresh();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (var form = new EditDictionaryForm(ActionType.Create, FilterTestDictionary()))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (TestService.DictionaryRecordAlreadyExists(form.td))
                    {
                        MessageBox.Show("Test with this code already exists in the dictionary.", "Error");
                    }
                    else
                    {
                        TestService.Add(form.td);
                        MessageBox.Show("Test added to dictionary.", "Test added");
                        SearchForTests();
                    }
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForTests();
        }

        private void radioButtonPhysical_CheckedChanged(object sender, EventArgs e)
        {
            SearchForTests();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewTests.SelectedRows.Count == 0)
                MessageBox.Show("No tests were selected for editing.", "Error");
            else
            {
                TestDictionary td = new TestDictionary();
                td.Code = dataGridViewTests.SelectedRows[0].Cells["Code"].Value.ToString();
                td.Name = dataGridViewTests.SelectedRows[0].Cells["Name"].Value.ToString();
                td.Type = dataGridViewTests.SelectedRows[0].Cells["Type"].Value.ToString();
                using (var form = new EditDictionaryForm(ActionType.Update, td))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        TestService.Update(form.td);
                        MessageBox.Show("A test with code " + form.td.Code + " was updated in the dictionary.", "Test updated");
                        SearchForTests();
                    }
                }
            }
        }
        TestDictionary FilterTestDictionary()
        {
            TestDictionary td = new TestDictionary();
            td.Code = labelledTextBoxCode.Input;
            td.Name = labelledTextBoxName.Input;
            if (radioButtonLaboratory.Checked)
                td.Type = TestType.Laboratory.ToCode();
            else
                td.Type = TestType.Physical.ToCode();
            return td;
        }
    }
}
