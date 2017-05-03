using Clinic.Interface.Common;
using Clinic.Data;
using System;

namespace Clinic.Interface.Admin.RolesFilters
{
    public partial class DoctorFilters : RolesFiltersBase
    {
        public string LicenceNumber
        {
            get { return inputLicenceNumber.Input; }
            set { inputLicenceNumber.Input = value; }
        }

        private LabelledTextBox inputLicenceNumber = new LabelledTextBox();

        public DoctorFilters()
        {
            InitializeComponent();
        }

        public Doctor GetDoctor() => new Doctor
        {
            Name = inputName.Input,
            Surname = inputSurname.Input,
            LicenseNumber = inputLicenceNumber.Input
        };

        protected override void OnClear()
        {
            inputLicenceNumber.Input = String.Empty;

            base.OnClear();
        }

        protected override void OnCreate()
        {
            base.OnCreate();

            inputLicenceNumber.Label = "Licence number";
            inputLicenceNumber.Width = 100;
            AddControl(inputLicenceNumber);
        }
    }
}
