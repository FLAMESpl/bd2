using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Clinic.Facades.Users;
using Clinic.Data;
using System.Collections.Generic;

namespace Clinic.Interface.Admin
{
    public partial class UserFilters : UserControl
    {
        private Dictionary<int, Role?> rolesMapping = new Dictionary<int, Role?>();

        public UserFilters()
        {
            InitializeComponent();
            InitializeRoles();
        }

        public User GetUser() => new User
        {
            Username = inputUsername.Input,
            Role = SelectedRole != null ? SelectedRole.Value.ToCode() : null
        };

        private Role? SelectedRole => rolesMapping[inputRoles.Input.SelectedIndex];

        private void InitializeRoles()
        {
            var roles = (Role[])Enum.GetValues(typeof(Role));
            int it = 1;
            rolesMapping.Add(0, null);
            foreach (var role in roles)
            {
                rolesMapping.Add(it, role);
                it++;
            }
            inputRoles.Input.Items.Add("<all>");
            inputRoles.Input.Items.AddRange(roles.Select(r => r.ToDisplayName()).ToArray());
            inputRoles.Input.SelectedIndex = 0;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            inputUsername.Input = string.Empty;
            inputRoles.Input.SelectedIndex = 0;
        }
    }
}
