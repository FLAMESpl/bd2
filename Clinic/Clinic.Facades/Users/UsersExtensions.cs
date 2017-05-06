using Clinic.Data;
using Clinic.Data.Helpers;
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

        public static void DeleteRoleForUser(this ClinicDataContext db, User user)
        {
            var role = RolesExtensions.GetFromCode(user.Role).Value;

            switch (role)
            {
                case Role.Doctor:
                    db.Doctors.DeleteOnSubmit(user.Doctor);
                    break;
                case Role.Registrator:
                    db.Registrators.DeleteOnSubmit(user.Registrator);
                    break;
                case Role.LabAssistant:
                    db.LabAssistants.DeleteOnSubmit(user.LabAssistant);
                    break;
                case Role.LabManager:
                    db.LabManagers.DeleteOnSubmit(user.LabManager);
                    break;
                case Role.Administrator:
                default:
                    break;
            }
        }

        public static DataContextLoaderDescriptor IncludeAllRoles(this DataContextLoaderDescriptor desc)
        {
            return desc
                .Include<User>(u => u.Doctor)
                .Include<User>(u => u.LabAssistant)
                .Include<User>(u => u.LabManager)
                .Include<User>(u => u.Registrator);
        }
    }
}
