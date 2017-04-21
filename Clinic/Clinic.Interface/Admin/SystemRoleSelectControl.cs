using Clinic.Facades.User;
using System;
using System.Windows.Forms;

namespace Clinic.Interface.Admin
{
    public partial class SystemRoleSelectControl : UserControl
    {
        public SystemRoleSelectControl()
        {
            InitializeComponent();
            AddRadioButtons();
        }

        private void AddRadioButtons()
        {
            var roles = (Role[])Enum.GetValues(typeof(Role));
            var radio = new RadioButton
            {
                Text = "All",
                AutoSize = true
            };
            flowLayoutPanel.Controls.Add(radio);
            radio.Checked = true;

            foreach (var role in roles)
            {
                radio = new RadioButton
                {
                    Text = role.ToDisplayName(),
                    AutoSize = true
                };
                flowLayoutPanel.Controls.Add(radio);
            }
        }
    }
}
