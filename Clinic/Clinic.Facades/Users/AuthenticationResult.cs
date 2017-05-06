using Clinic.Data;

namespace Clinic.Facades.Users
{
    public class AuthenticationResult
    {
        public Role? Role { get; private set; }
        public User User { get; private set; }
        public bool Success { get; private set; }

        public AuthenticationResult(Role? role, User user)
        {
            Role = role;
            User = user;
            Success = role != null;
        }
    }
}
