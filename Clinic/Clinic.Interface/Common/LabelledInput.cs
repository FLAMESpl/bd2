using Clinic.Interface.Common.Events;
using System;
using System.Windows.Forms;

namespace Clinic.Interface.Common
{
    public partial class LabelledInput : UserControl
    {
        public event EventHandler InputChanged;

        public string Label
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public string Input
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public LabelledInput()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            InputChanged?.Invoke(this, new InputChangedEventArgs(textBox.Text));
        }
    }
}
