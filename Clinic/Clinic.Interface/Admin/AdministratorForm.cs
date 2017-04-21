using Clinic.Facades.Users;
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

        private void buttonBrowse_Click(object sender, System.EventArgs e)
        {
            var users = UsersService.Match(labelledInputUsername.Input, systemRoleSelectControl.Role);
            sourceUsers.Clear();
            sourceUsers.AddRange(users.Select(u => new UserView(u)));
        }
    }
}
