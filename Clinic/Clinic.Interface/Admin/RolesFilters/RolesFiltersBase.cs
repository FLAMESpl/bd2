using Clinic.Interface.Common;
using System;

namespace Clinic.Interface.Admin.RolesFilters
{
    public partial class RolesFiltersBase : Filters
    {
        public string Name
        {
            get { return inputName.Input; }
            set { inputName.Input = value; }
        }

        public string Surname
        {
            get { return inputSurname.Input; }
            set { inputSurname.Input = value; }
        }

        protected LabelledTextBox inputName = new LabelledTextBox();
        protected LabelledTextBox inputSurname = new LabelledTextBox();

        public RolesFiltersBase()
        {
            InitializeComponent();
        }

        protected override void OnClear()
        {
            inputName.Input = String.Empty;
            inputSurname.Input = String.Empty;

            base.OnClear();
        }

        protected override void OnCreate()
        {
            inputName.Label = "Name";
            inputName.Width = 120;
            AddControl(inputName);

            inputSurname.Label = "Surname";
            inputSurname.Width = 120;
            AddControl(inputSurname);

            base.OnCreate();
        }
    }
}
