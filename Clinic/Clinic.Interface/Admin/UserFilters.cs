using System;
using System.Data;
using System.Linq;
using Clinic.Facades.Users;
using Clinic.Data;
using System.Collections.Generic;
using Clinic.Interface.Common;

namespace Clinic.Interface.Admin
{
    public partial class UserFilters : Filters
    {
        private Dictionary<int, Role?> rolesMapping = new Dictionary<int, Role?>();
        private LabelledTextBox inputUsername = new LabelledTextBox();
        private LabelledComboBox inputRoles = new LabelledComboBox();

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

        protected override void OnClear()
        {
            inputUsername.Input = String.Empty;
            inputRoles.Input.SelectedIndex = 0;
        }

        protected override void OnCreate()
        {
            inputUsername.Label = "Username";
            inputUsername.Width = 120;
            AddControl(inputUsername);
            
            inputRoles.Label = "Role";
            inputRoles.Width = 100;
            AddControl(inputRoles);

            base.OnCreate();
        }

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
    }
}
