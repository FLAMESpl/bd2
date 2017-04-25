using Clinic.Interface.Common.Events;
using System;
using System.Windows.Forms;

namespace Clinic.Interface.Common
{
    public partial class LabelledTextBox : LabelledInput
    {
        private TextBox textBox;

        public string Input
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public LabelledTextBox()
        {
            InitializeComponent();
            InitializeTextBox();
        }

        private void InitializeTextBox()
        {
            textBox = new TextBox
            {
                Dock = DockStyle.Fill
            };
            LoadInput(textBox);
        }
    }
}
