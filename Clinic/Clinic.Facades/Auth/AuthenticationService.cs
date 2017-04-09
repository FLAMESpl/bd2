using Clinic.Data;
using System.Linq;

namespace Clinic.Facades.Auth
{
    public static class AuthenticationService
    {
        private const string ADMINSTRATOR_CODE = "ADM";
        private const string DOCTOR_CODE = "DOC";
        private const string LABASSISTANT_CODE = "LABASS";
        private const string LABMANAGER_CODE = "LABMAN";
        private const string REGISTRATOR_CODE = "REG";

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
                case ADMINSTRATOR_CODE:
                    return Role.Administrator;
                case DOCTOR_CODE:
                    return Role.Doctor;
                case LABASSISTANT_CODE:
                    return Role.LabAssistant;
                case LABMANAGER_CODE:
                    return Role.LabManager;
                case REGISTRATOR_CODE:
                    return Role.Registrator;
                default:
                    return null;
            }
        }

        private static string GetCodeFromRole(Role role)
        {
            switch (role)
            {
                case Role.Administrator:
                    return ADMINSTRATOR_CODE;
                case Role.Doctor:
                    return DOCTOR_CODE;
                case Role.Registrator:
                    return REGISTRATOR_CODE;
                case Role.LabAssistant:
                    return LABASSISTANT_CODE;
                case Role.LabManager:
                    return LABMANAGER_CODE;
                default:
                    return null;
            }
        }
    }
}
