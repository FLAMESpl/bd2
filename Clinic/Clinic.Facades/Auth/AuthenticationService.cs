using Clinic.Data;
using System.Linq;

namespace Clinic.Facades.Auth
{
    public static class AuthenticationService
    {
        public static AuthenticationResult Authenticate(string username, string password)
        {
            using (var db = new ClinicDataContext())
            {
                var user = db.Users.Where(u => u.Username == username && u.Password == password).SingleOrDefault();
                Role? role = (user == null) ? null : GetRoleFromCode(user.Role);
                return new AuthenticationResult(role);
            }
        }

        private static Role? GetRoleFromCode(string code)
        {
            switch(code)
            {
                case "ADM":
                    return Role.Administrator;
                case "DOC":
                    return Role.Doctor;
                case "LABASS":
                    return Role.LabAssistant;
                case "LABMAN":
                    return Role.LabManager;
                case "REG":
                    return Role.Registrator;
                default:
                    return null;
            }
        }
    }
}
