using Clinic.Data;

namespace Clinic.Facades.Doctors
{
    public static class DoctorsExtensions
    {
        public static string GetFullName(this Doctor doctor) => $"{doctor.Name} {doctor.Surname}";
    }
}
