using System;
using Clinic.Interface.Common;
using Clinic.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class AddressFilters : Filters
    {
        public event EventHandler AddressAdded;

        private bool addButtonEnabled = true;
        public bool AddButtonEnabled
        {
            get { return addButtonEnabled; }
            set
            {
                addButtonEnabled = value;
                addButton.Enabled = value;
                addButton.Visible = value;
            }
        }

        private LabelledTextBox cityInput = new LabelledTextBox { Label = "City", Size = new Size(150, 50) };
        private LabelledTextBox streetInput = new LabelledTextBox { Label = "Steet", Size = new Size(150, 50) };
        private LabelledTextBox houseInput = new LabelledTextBox { Label = "House", Size = new Size(50, 50) };
        private LabelledTextBox flatInput = new LabelledTextBox { Label = "Flat", Size = new Size(50, 50) };
        private Button addButton = new Button { Text = "Add", Width = 50 };

        public AddressFilters()
        {
            InitializeComponent();
        }

        public Address GetAddress() => new Address
        {
            City = cityInput.Input ?? String.Empty,
            FlatNumber = flatInput.Input ?? String.Empty,
            HouseNumber = houseInput.Input ?? String.Empty,
            Street = streetInput.Input ?? String.Empty,
            IsValid = true
        };

        protected override void OnCreate()
        {
            addButton.Margin = ClearButtonPadding;
            addButton.Click += (s, e) => AddressAdded?.Invoke(this, e);

            AddControl(cityInput);
            AddControl(streetInput);
            AddControl(houseInput);
            AddControl(flatInput);
            AddControl(addButton);

            base.OnCreate();
        }

        protected override void OnClear()
        {
            cityInput.Input = String.Empty;
            streetInput.Input = String.Empty;
            houseInput.Input = String.Empty;
            flatInput.Input = String.Empty;

            base.OnClear();
        }
    }

}
