using Clinic.Facades.Users;
using System;

namespace Clinic.Interface.Admin.Events
{
    public class SelectedRoleChangedEventArgs : EventArgs
    {
        public Role? NewRole { get; private set; }

        public SelectedRoleChangedEventArgs(Role? newRole)
        {
            NewRole = newRole;
        }
    }
}
