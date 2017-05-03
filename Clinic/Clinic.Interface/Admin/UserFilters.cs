using System;
using System.Data;
using System.Linq;
using Clinic.Facades.Users;
using Clinic.Data;
using System.Collections.Generic;
using Clinic.Interface.Common;
using Clinic.Interface.Admin.Events;

namespace Clinic.Interface.Admin
{
    public partial class UserFilters : Filters
    {
        public event EventHandler<SelectedRoleChangedEventArgs> SelectedRoleChanged;

        private bool allRolesEnabled = true;
        public bool AllRolesEnabled
        {
            get { return allRolesEnabled; }
            set
            {
                if (allRolesEnabled == value)
                    return;

                allRolesEnabled = value;
                InitializeRoles();
            }
        }

        public string Username
        {
            get { return inputUsername.Input; }
            set { inputUsername.Input = value; }
        }

        public Role? Role
        {
            get { return rolesMapping[inputRoles.Input.SelectedIndex]; }
            set { inputRoles.Input.SelectedIndex = rolesMapping.Where(x => x.Value == value).Single().Key; }
        }

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
            Role = Role != null ? Role.Value.ToCode() : null
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

        private void InitializeRoles()
        {
            var roles = RolesExtensions.VisibleRoles;
            int it = 0;

            rolesMapping.Clear();
            inputRoles.Input.Items.Clear();

            if (allRolesEnabled)
            {
                rolesMapping.Add(it, null);
                inputRoles.Input.Items.Add("<all>");
                it++;
            }
            foreach (var role in roles)
            {
                rolesMapping.Add(it, role);
                it++;
            }

            inputRoles.Input.Items.AddRange(roles.Select(r => r.ToDisplayName()).ToArray());
            inputRoles.Input.SelectedIndexChanged += RolesComboBoxSelectedItemChanged;
            inputRoles.Input.SelectedIndex = 0;
        }

        private void RolesComboBoxSelectedItemChanged(object sender, EventArgs e)
        {
            SelectedRoleChanged?.Invoke(this, new SelectedRoleChangedEventArgs(Role));
        }
    }
}
