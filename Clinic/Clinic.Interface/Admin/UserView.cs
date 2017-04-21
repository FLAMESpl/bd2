using Clinic.Data;
using Clinic.Facades.Users;

namespace Clinic.Interface.Admin
{
    public class UserView
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }

        public UserView()
        {
        }

        public UserView(User user)
        {
            UserId = user.Id;
            Username = user.Username;
            Role = (RolesExtensions.GetFromCode(user.Role).Value).ToDisplayName();
        }
    }
}
