using Clinic.Data;
using System.Windows.Forms;

namespace Clinic.Interface.Common
{
    public class ClinicForm : Form
    {
        protected User ActiveUser { get; private set; }

        public void ShowDialog(User user)
        {
            ActiveUser = user;
            ShowDialog();
        }
    }
}
