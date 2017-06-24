using Clinic.Facades.Visits;
using System;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class VisitDescriptionForm : Form
    {
        private DailyVisit visit;
        private bool updated;

        public VisitDescriptionForm()
        {
            InitializeComponent();
        }

        public VisitDescriptionForm(DailyVisit visit)
        {
            InitializeComponent();
            this.visit = visit;
            textBoxDescription.Text = visit.Description ?? String.Empty;
            doneCancelDialog.Done += Done;
            doneCancelDialog.Cancel += Cancel;
        }

        public new string ShowDialog()
        {
            base.ShowDialog();
            return updated ? textBoxDescription.Text : null;
        }

        private void Done(object sender, EventArgs e)
        {
            VisitsService.UpdateDescription(visit.VisitId.Value, textBoxDescription.Text);
            updated = true;
            Close();
        }

        private void Cancel(object sender, EventArgs e)
        {
            updated = false;
            Close();
        }
    }
}
