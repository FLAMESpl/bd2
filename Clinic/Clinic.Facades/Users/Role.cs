namespace Clinic.Facades.Users
{
    public enum Role
    {
        Administrator,
        Doctor,
        Registrator,
        LabAssistant,
        LabManager
    }

    public static class RolesExtensions
    {
        private const string ADMINSTRATOR_CODE = "ADM";
        private const string DOCTOR_CODE = "DOC";
        private const string LABASSISTANT_CODE = "LABASS";
        private const string LABMANAGER_CODE = "LABMAN";
        private const string REGISTRATOR_CODE = "REG";

        public static string ToDisplayName(this Role role)
        {
            switch (role)
            {
                case Role.Administrator:
                    return "Administrator";
                case Role.Doctor:
                    return "Doctor";
                case Role.Registrator:
                    return "Registrator";
                case Role.LabAssistant:
                    return "Lab assistant";
                case Role.LabManager:
                    return "Lab manager";
                default:
                    return "unknown";
            }
        }

        public static Role? GetFromCode(string code)
        {
            switch (code)
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

        public static string ToCode(this Role role)
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
