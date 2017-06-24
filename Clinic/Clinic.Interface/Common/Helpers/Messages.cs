using System;
using System.Windows.Forms;

namespace Clinic.Interface.Common.Helpers
{
    public static class Messages
    {
        public static void ShowMessage(this Exception exception)
        {
            MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void EntityCreated(string name) => ConfirmationMessage(name, "created");
        public static void EntityDeleted(string name) => ConfirmationMessage(name, "deleted");
        public static void EntityUpdated(string name) => ConfirmationMessage(name, "updated");

        private static void ConfirmationMessage(string subject, string action) => MessageBox.Show($"{subject} has been successfully {action}");
    }
}
