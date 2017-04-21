using Clinic.Data;
using Clinic.Data.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Facades.Users
{
    public static class UsersService
    {
        public static User Get(long id)
        {
            using (var db = DataContextFactory.Create())
            {
                var result = db.Users.Single(u => u.Id == id);
                return result;
            }
        }

        public static List<User> Match(string userPattern, Role? role)
        {
            using (var db = DataContextFactory.Create())
            {
                var results = db.Users.Where(u => u.Username.Contains(userPattern));
                return results.ToList();
            }
        }
    }
}
