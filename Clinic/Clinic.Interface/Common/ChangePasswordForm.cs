using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clinic.Data;
using Clinic.Interface.Common.Helpers;
using Clinic.Facades.Users;

namespace Clinic.Interface.Common
{
    public partial class ChangePasswordForm : Form
    {
        private User user;

        public ChangePasswordForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void doneCancelDialog_Cancel(object sender, EventArgs e)
        {
            Hide();
        }

        private void doneCancelDialog_Done(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labelledTextBox.Input))
            {
                MessageBox.Show("Enter new password!");
            }
            else
            {
                user.Password = Cryptography.GetCrypt(labelledTextBox.Input);
                UsersService.Update(user);
                MessageBox.Show("Password changed!");
                Hide();
            }            
        }
    }
}
