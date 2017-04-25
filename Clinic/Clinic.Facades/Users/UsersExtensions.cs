using Clinic.Data;
using System;

namespace Clinic.Facades.Users
{
    public static class UsersExtensions
    {
        public static void GetNameAndSurname(this User user, out string name, out string surname)
        {
            var role = RolesExtensions.GetFromCode(user.Role);
            if (!role.HasValue)
            {
                name = String.Empty;
                surname = String.Empty;
            }
            else
            {
                switch (role.Value)
                {
                    case Role.Administrator:
                        name = String.Empty;
                        surname = String.Empty;
                        break;
                    case Role.Doctor:
                        name = user.Doctor.Name;
                        surname = user.Doctor.Surname;
                        break;
                    case Role.Registrator:
                        name = user.Registrator.Name;
                        surname = user.Registrator.Surname;
                        break;
                    case Role.LabAssistant:
                        name = user.LabAssistant.Name;
                        surname = user.LabAssistant.Surname;
                        break;
                    case Role.LabManager:
                        name = user.LabManager.Name;
                        surname = user.LabManager.Surname;
                        break;
                    default:
                        name = String.Empty;
                        surname = String.Empty;
                        break;
                }
            }
        }
    }
}
