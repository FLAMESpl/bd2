using Clinic.Facades.Users;
using Clinic.Interface.Admin.Events;
using Clinic.Interface.Admin.RolesFilters;
using Clinic.Interface.Common;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.Interface.Admin
{
    public partial class UserUpdateForm : Form
    {
        private Dictionary<Role, Func<RolesFiltersBase>> roleFiltersDictionary 
            = new Dictionary<Role, Func<RolesFiltersBase>>();

        private ActionType actionType;

        private RolesFiltersBase RoleFilters
        {
            get { return (RolesFiltersBase)groupBoxRole.Controls[0]; }
            set
            {
                value.Dock = DockStyle.Fill;
                groupBoxRole.Controls.Clear();
                groupBoxRole.Controls.Add(value);
            }
        }

        public UserUpdateForm()
        {
            InitializeComponent();
        }

        public UserUpdateForm(UserView userView, ActionType actionType)
        {
            InitializeComponent();
            InitializeRoleFilters();
            FillUser(userView);

            this.actionType = actionType;
        }

        private void InitializeRoleFilters()
        {
            roleFiltersDictionary.Add(Role.Administrator, () => new RolesFiltersBase());
            roleFiltersDictionary.Add(Role.Doctor, () => new DoctorFilters());
            roleFiltersDictionary.Add(Role.LabAssistant, () => new RolesFiltersBase());
            roleFiltersDictionary.Add(Role.LabManager, () => new RolesFiltersBase());
            roleFiltersDictionary.Add(Role.Registrator, () => new RolesFiltersBase());

            userFilters.SelectedRoleChanged += UserFiltersSelctedRoleChanged;
        }

        private void FillUser(UserView userView)
        {
            RoleFilters = new RolesFiltersBase();

            string name, surname;
            var user = UsersService.Get(userView.UserId);
            var role = RolesExtensions.GetFromCode(user.Role).Value;
            user.GetNameAndSurname(out name, out surname);

            userFilters.Role = role;
            userFilters.Username = user.Username;
            RoleFilters.Name = name;
            RoleFilters.Surname = surname;
        }

        private void UserFiltersSelctedRoleChanged(object sender, SelectedRoleChangedEventArgs e)
        {
            var role = e.NewRole.Value;
            var roleFilters = roleFiltersDictionary[role].Invoke();
            
            roleFilters.Name = RoleFilters.Name;
            roleFilters.Surname = RoleFilters.Surname;

            groupBoxRole.Text = role.ToDisplayName();
            RoleFilters = roleFilters;
        }
    }
}
