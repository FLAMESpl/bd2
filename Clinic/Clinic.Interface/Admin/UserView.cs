using Clinic.Data;
using Clinic.Facades.Users;

namespace Clinic.Interface.Admin
{
    public class UserView
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string RoleDisplayName => Role.ToDisplayName();
        public Role Role { get; set; }

        public UserView(string username, Role role)
        {
            Username = username;
            Role = role;
        }

        public UserView(User user)
        {
            UserId = user.Id;
            Username = user.Username;
            Role = RolesExtensions.GetFromCode(user.Role).Value;
        }
    }
}
