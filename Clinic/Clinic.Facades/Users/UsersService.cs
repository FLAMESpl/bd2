using Clinic.Data;
using Clinic.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Facades.Users
{
    public static class UsersService
    {
        public static void Create(User user)
        {
            using (var db = DataContextFactory.Create())
            {
                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
            }
        }

        public static void Update(User updatedUser)
        {
            using (var db = CreateContextWithAllRolesIncluded())
            {
                var user = db.Users.Single(u => u.Id == updatedUser.Id);

                if (user.Role != updatedUser.Role)
                {
                    db.DeleteRoleForUser(user);
                    user.Role = updatedUser.Role;
                }

                user.Doctor = updatedUser.Doctor;
                user.LabAssistant = updatedUser.LabAssistant;
                user.LabManager = updatedUser.LabManager;
                user.Registrator = updatedUser.Registrator;

                user.Username = updatedUser.Username;
                user.Password = updatedUser.Password;

                db.SubmitChanges();
            }
        }

        public static User Get(long id)
        {
            using (var db = CreateContextWithAllRolesIncluded())
            {
                var result = db.Users.Single(u => u.Id == id);
                return result;
            }
        }

        public static List<User> Match(User searchCriteria)
        {
            using (var db = DataContextFactory.Create())
            {
                var results = db.Users.Where(u => u.Username.Contains(searchCriteria.Username));
                if (!String.IsNullOrEmpty(searchCriteria.Role))
                    results = results.Where(u => u.Role == searchCriteria.Role);

                return results.ToList();
            }
        }

        private static ClinicDataContext CreateContextWithAllRolesIncluded()
        {
            return DataContextFactory.Create(x => x
                .Include<User>(u => u.Doctor)
                .Include<User>(u => u.LabAssistant)
                .Include<User>(u => u.LabManager)
                .Include<User>(u => u.Registrator));
        }
    }
}
