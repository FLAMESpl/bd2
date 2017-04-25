using Clinic.Data;
using Clinic.Facades.Users;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.Interface.Admin
{
    public partial class AdministratorForm : Form
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
            sourceUsers.Clear();
            sourceUsers.AddRange(users.Select(u => new UserView(u)));
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
    }
}
