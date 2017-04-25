using System.Windows.Forms;

namespace Clinic.Interface.Common
{
    public partial class Filters : UserControl
    {
        public Filters()
        {
            InitializeComponent();
            Initialize();
        }

        protected virtual void OnClear()
        {
        }

        protected virtual void OnCreate()
        {
        }

        protected void AddControl(Control control) => flowLayoutPanel.Controls.Add(control);

        private void Initialize()
        {
            OnCreate();
            var clearButton = new Button
            {
                Margin = new Padding(3, 25, 3, 3),
                Text = "Clear",
                Width = 50
            };
            
            clearButton.Click += (s, e) => OnClear();
            AddControl(clearButton);
        }
    }
}
