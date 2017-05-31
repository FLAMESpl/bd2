using Clinic.Data;
using Clinic.Facades.Users;
using Clinic.Interface.Admin;
using Clinic.Interface.Common;
using Clinic.Interface.Doctors;
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
                ShowUserWindow(result.Role.Value, result.User);
            }
            else
            {
                MessageBox.Show("Authentication error");
            }
        }

        private void ShowUserWindow(Role role, User user)
        {
            if (user == null)
                throw new ArgumentException("User cannot be null", nameof(user));

            ClinicForm form = null;

            switch (role)
            {
                case Role.Administrator:
                    form = new AdministratorForm();
                    break;
                case Role.Doctor:
                    form = new DoctorForm(user.Doctor.Id);
                    break;
                case Role.Registrator:
                    form = new RegistratorForm();
                    break;
                case Role.LabAssistant:
                    //form = new AssistantForm();
                    break;
                case Role.LabManager:
                    //form = new ManagerForm();
                    break;
                default:
                    break;
            }

            if (form != null)
            {
                Hide();
                form.ShowDialog(user);
                ClearInputs();
                Show();
            }
        }

        private void ClearInputs()
        {
            textBoxLogin.Text = String.Empty;
            textBoxPassword.Text = String.Empty;
        }

        private void logInTrigger(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                buttonLogIn_Click(sender, e);
            }
        }
    }
}
