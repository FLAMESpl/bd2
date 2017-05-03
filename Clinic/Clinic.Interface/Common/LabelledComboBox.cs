using System.ComponentModel;
using System.Windows.Forms;

namespace Clinic.Interface.Common
{
    public partial class LabelledComboBox : LabelledInput
    {
        public ComboBox Input { get; private set; }

        public LabelledComboBox()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        public LabelledComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            Input = new ComboBox
            {
                Dock = DockStyle.Fill
            };

            LoadInput(Input);
        }
    }
}
