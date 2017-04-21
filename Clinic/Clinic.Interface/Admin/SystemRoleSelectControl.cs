using Clinic.Facades.Auth;
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
                Text = radio.Text
            };

        }
    }
}
