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

        public LabelledInput()
        {
            InitializeComponent();
        }

        protected void LoadInput(Control control)
        {
            tableLayoutPanel.Controls.Add(control, 0, 1);
        }
    }
}
