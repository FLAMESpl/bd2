using Clinic.Data;
using Clinic.Data.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.Facades.Doctors
{
    public static class DoctorsService
    {
        public static List<Doctor> GetAll()
        {
            using (var db = DataContextFactory.Create())
            {
                return db.Doctors.ToList();
            }
        }
    }
}
