using Clinic.Data;
using Clinic.Facades.Users;
using Clinic.Interface.Admin.Events;
using Clinic.Interface.Admin.RolesFilters;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
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
        private long userId;

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
            this.actionType = actionType;
            this.userId = userView.UserId;
            FillUser(userView);
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

            string name, surname, username;
            var role = Role.Registrator;

            if (actionType == ActionType.Update)
            {
                var user = UsersService.Get(userView.UserId);
                username = user.Username;
                user.GetNameAndSurname(out name, out surname);
                role = RolesExtensions.GetFromCode(user.Role) ?? role;
                labelledTextBoxPassword.Input = string.Empty;
            }
            else
            {
                name = String.Empty;
                surname = String.Empty;
                username = String.Empty;
            }

            userFilters.Role = role;
            userFilters.Username = username;
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

        private void doneCancelDialog_Done(object sender, EventArgs e)
        {
            if (actionType == ActionType.Create)
            {
                if (string.IsNullOrEmpty(labelledTextBoxPassword.Input))
                {
                    MessageBox.Show("Enter password!");
                }
                else
                {
                    UsersService.Create(CreateUser());
                    Close();
                }
            }
            else if (actionType == ActionType.Update)
            {
                if (string.IsNullOrEmpty(labelledTextBoxPassword.Input))
                {
                    User user = CreateUser();
                    user.Password = null;
                    UsersService.Update(user);
                    Close();
                }
                else
                {
                    UsersService.Update(CreateUser());
                    Close();
                }
                
            }
        }
        private void doneCancelDialog_Cancel(object sender, EventArgs e)
        {
            Close();
        }

        private User CreateUser()
        {
            var role = userFilters.Role.Value;
            var user = new User
            {
                Id = userId,                
                Password = Cryptography.GetCrypt(labelledTextBoxPassword.Input),
                Username = userFilters.Username,
                Role = role.ToCode()
            };
            
            switch (role)
            {
                case Role.Doctor:
                    user.Doctor = new Doctor
                    {
                        LicenseNumber = ((DoctorFilters)RoleFilters).LicenceNumber,
                        Name = RoleFilters.Name,
                        Surname = RoleFilters.Surname
                    };
                    break;
                case Role.Registrator:
                    user.Registrator = new Data.Registrator
                    {
                        Name = RoleFilters.Name,
                        Surname = RoleFilters.Surname
                    };
                    break;
                case Role.LabAssistant:
                    user.LabAssistant = new LabAssistant
                    {
                        Name = RoleFilters.Name,
                        Surname = RoleFilters.Surname
                    };
                    break;
                case Role.LabManager:
                    user.LabManager = new Data.LabManager
                    {
                        Name = RoleFilters.Name,
                        Surname = RoleFilters.Surname
                    };
                    break;
                default:
                    break;
            }

            return user;
        }
    }
}
