using Clinic.Data;

namespace Clinic.Facades.Patients
{
    public static class PatientsExtensions
    {
        public static string GetFullName(this Patient doctor) => $"{doctor.Name} {doctor.Surname}";
    }
}
