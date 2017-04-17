using Clinic.Data;
using Clinic.Facades.Doctors;
using Clinic.Facades.Visits;
using Clinic.Interface.Common;
using System;
using System.Linq;
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
            FillDoctors();
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

        private void FillDoctors()
        {
            var doctors = DoctorsService.GetAll().Select(d => new ListboxDoctorItem(d));
            listBoxDoctors.Items.AddRange(doctors.ToArray());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
