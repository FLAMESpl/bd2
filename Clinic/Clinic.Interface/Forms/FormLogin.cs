using Clinic.Facades.Auth;
using System;
using System.Windows.Forms;

namespace Clinic.Interface.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            var result = AuthenticationService.Authenticate(textBoxLogin.Text, textBoxPassword.Text);
            if (result.Success)
            {
                MessageBox.Show($"Logged in as {result.Role.Value.ToDisplayName()}");
            }
            else
            {
                MessageBox.Show("Authentication error");
            }
        }
    }
}
