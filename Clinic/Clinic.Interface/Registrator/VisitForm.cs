using Clinic.Data;
using Clinic.Facades.Visits;
using Clinic.Interface.Common;
using System;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class VisitForm : Form
    {
        private Patient patient;

        public VisitForm()
        {
            InitializeComponent();
        }

        public VisitForm(Patient patient, ActionType actionType)
        {
            InitializeComponent();

            this.patient = patient;
            labelPatientName.Text = $"{patient.Name} {patient.Surname}";

            FillVisits(new DateTime(1, 1, 1, 8, 0, 0), new DateTime(1, 1, 1, 12, 0, 0), 15);
        }

        private void FillVisits(DateTime startTime, DateTime endTime, int minutesPerVisit)
        {
            var timeSpan = endTime - startTime;
            var numberOfVisits = timeSpan.TotalMinutes / minutesPerVisit;

            var actualTime = startTime;
            for (int i = 0; i < numberOfVisits; i++)
            {
                var dailyVisit = new DailyVisit();
                dailyVisit.VisitHour = actualTime;
                bindingSourceDailyVisit.Add(dailyVisit);
                actualTime = actualTime.AddMinutes(minutesPerVisit);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
