using System.Windows.Forms;
using System;
using Clinic.Data;
using Clinic.Facades.Users;

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

        protected override void OnLoad(EventArgs e)
        {
            if (ActiveUser != null && ActiveUser.Role != Role.Administrator.ToCode()) // in case it is called by designer
            {
                string name, surname;
                ActiveUser.GetNameAndSurname(out name, out surname);

                var statusStripLabel = new ToolStripStatusLabel
                {
                    Text = $"{name} {surname}"
                };

                var statusStip = new StatusStrip();
                statusStip.Items.Add(statusStripLabel);

                Controls.Add(statusStip);
            }

            base.OnLoad(e);
        }
    }
}
