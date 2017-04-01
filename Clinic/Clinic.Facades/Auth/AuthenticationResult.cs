namespace Clinic.Facades.Auth
{
    public class AuthenticationResult
    {
        public Role? Role { get; private set; }
        public bool Success { get; private set; }

        public AuthenticationResult(Role? role)
        {
            Role = role;
            Success = role != null;
        }
    }
}
