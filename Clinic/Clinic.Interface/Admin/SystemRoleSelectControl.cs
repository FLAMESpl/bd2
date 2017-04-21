using Clinic.Facades.Users;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.Interface.Admin
{
    public partial class SystemRoleSelectControl : UserControl
    {
        public Role? Role => (Role?)flowLayoutPanel.Controls.OfType<RadioButton>().First(r => r.Checked).Tag;

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
                AutoSize = true,
                Tag = null
            };
            flowLayoutPanel.Controls.Add(radio);
            radio.Checked = true;

            foreach (var role in roles)
            {
                radio = new RadioButton
                {
                    Text = role.ToDisplayName(),
                    AutoSize = true,
                    Tag = role
                };
                flowLayoutPanel.Controls.Add(radio);
            }
        }
    }
}
