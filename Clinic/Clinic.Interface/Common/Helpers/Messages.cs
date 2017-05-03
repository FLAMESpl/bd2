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
    }
}
