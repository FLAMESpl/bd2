namespace Clinic.Facades.Auth
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
        public static string ToDisplayName(this Role role)
        {
            switch (role)
            {
                case Role.Administrator:
                    return "administrator";
                case Role.Doctor:
                    return "doctor";
                case Role.Registrator:
                    return "registrator";
                case Role.LabAssistant:
                    return "lab assistant";
                case Role.LabManager:
                    return "lab manager";
                default:
                    return "unknown";
            }
        }
    }
    
}
