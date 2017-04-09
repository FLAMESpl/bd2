using System.Windows.Forms;

namespace Clinic.Interface.Common
{
    public partial class LabelledInput : UserControl
    {
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
    }
}
