using Clinic.Data;

namespace Clinic.Interface.Registrator
{
    public class DoctorListItem
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public bool Empty { get; private set; }

        public DoctorListItem()
        {
            Empty = true;
            Name = "<none>";
        }

        public DoctorListItem(Doctor doctor)
        {
            Id = doctor.Id;
            Name = $"{doctor.Name} {doctor.Surname}";
            Empty = false;
        }

        public override string ToString() => Name;
    }
}
