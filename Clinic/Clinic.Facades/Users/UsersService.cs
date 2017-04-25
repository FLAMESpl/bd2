using Clinic.Data;
using Clinic.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Facades.Users
{
    public static class UsersService
    {
        public static User Get(long id)
        {
            using (var db = DataContextFactory.Create(x => x
                .Include<User>(u => u.Doctor)
                .Include<User>(u => u.LabAssistant)
                .Include<User>(u => u.LabManager)
                .Include<User>(u => u.Registrator)))
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
    }
}
