using Clinic.Data;

namespace Clinic.Interface.Registrator
{
    public class ListboxDoctorItem
    {
        public long Id { get; private set; }
        public string Name { get; private set; }

        public ListboxDoctorItem(Doctor doctor)
        {
            Id = doctor.Id;
            Name = $"{doctor.Name} {doctor.Surname}";
        }

        public override string ToString() => Name;
    }
}
