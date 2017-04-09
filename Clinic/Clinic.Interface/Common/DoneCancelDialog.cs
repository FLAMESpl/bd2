using System;
using System.Windows.Forms;

namespace Clinic.Interface.Common
{
    public partial class DoneCancelDialog : UserControl
    {
        public event EventHandler Cancel;
        public event EventHandler Done;

        public DoneCancelDialog()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel?.Invoke(this, EventArgs.Empty);
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Done?.Invoke(this, EventArgs.Empty);
        }
    }
}
