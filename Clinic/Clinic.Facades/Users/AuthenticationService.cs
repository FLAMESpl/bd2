﻿using Clinic.Data.Helpers;
using System.Linq;

namespace Clinic.Facades.User
{
    public static class AuthenticationService
    {
        public static AuthenticationResult Authenticate(string username, string password)
        {
            using (var db = DataContextFactory.Create())
            {
                var user = db.Users.Where(u => u.Username == username && u.Password == password).SingleOrDefault();
                Role? role = (user == null) ? null : RolesExtensions.GetFromCode(user.Role);
                return new AuthenticationResult(role);
            }
        }
    }
}
