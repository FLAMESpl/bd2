using Clinic.Data;

namespace Clinic.Facades.Auth
{
    public static class AuthenticationService
    {
        public static AuthenticationResult Authenticate(string userName, string password)
        {
            var db = new ClinicDataContext();
            
            return new AuthenticationResult(Role.Administrator);
        }
    }
}
