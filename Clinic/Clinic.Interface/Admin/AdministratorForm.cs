using Clinic.Facades.Users;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.Interface.Admin
{
    public partial class AdministratorForm : ClinicForm
    {
        public AdministratorForm()
        {
            InitializeComponent();
        }

        private void EditUser(UserView user)
        {
            using (var form = new UserUpdateForm(user, ActionType.Update))
            {                
                form.ShowDialog();
            }
        }

        private void buttonBrowse_Click(object sender, System.EventArgs e)
        {
            var users = UsersService.Match(userFilters.GetUser());
            var adminRole = Role.Administrator.ToCode();
            sourceUsers.Clear();
            sourceUsers.AddRange(users.Where(u => u.Role != adminRole).Select(u => new UserView(u)));
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            var columnName = grid.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "Edit":
                    EditUser((UserView)sourceUsers.Current);
                    break;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var role = userFilters.Role ?? Role.Registrator;
            var user = new UserView(userFilters.Username, role);

            using (var form = new UserUpdateForm(user, ActionType.Create))
            {
                form.ShowDialog();
            }
        }
    }
}
