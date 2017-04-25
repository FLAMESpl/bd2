using System.Windows.Forms;

namespace Clinic.Interface.Common
{
    public partial class Filters : UserControl
    {
        public Filters()
        {
            InitializeComponent();
            OnCreate();
        }

        protected virtual void OnClear()
        {
        }

        protected virtual void OnCreate()
        {
            var clearButton = new Button
            {
                Margin = new Padding(3, 25, 3, 3),
                Text = "Clear",
                Width = 50
            };


            clearButton.Click += (s, e) => OnClear();
            AddControl(clearButton);
        }

        protected void AddControl(Control control) => flowLayoutPanel.Controls.Add(control);
    }
}
