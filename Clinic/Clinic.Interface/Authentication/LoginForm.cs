using Clinic.Facades.Users;
using Clinic.Interface.Admin;
using Clinic.Interface.LabManager;
using Clinic.Interface.Registrator;
using System;
using System.Windows.Forms;

namespace Clinic.Interface.Authentication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            var result = AuthenticationService.Authenticate(textBoxLogin.Text, textBoxPassword.Text);
            if (result.Success)
            {
                MessageBox.Show($"Logged in as {result.Role.Value.ToDisplayName()}");
                ShowUserWindow(result.Role.Value);
            }
            else
            {
                MessageBox.Show("Authentication error");
            }
        }

        private void ShowUserWindow(Role role)
        {
            Form form = null;

            switch (role)
            {
                case Role.Administrator:
                    form = new AdministratorForm();
                    break;
                case Role.Doctor:
                    break;
                case Role.Registrator:
                    form = new RegistratorForm();
                    break;
                case Role.LabAssistant:
                    break;
                case Role.LabManager:
                    form = new ManagerForm();
                    break;
                default:
                    break;
            }

            if (form != null)
            {
                Hide();
                form.ShowDialog();
                Close();
            }
        }
    }
}
