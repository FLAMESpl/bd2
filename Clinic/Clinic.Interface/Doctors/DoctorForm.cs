using Clinic.Facades.Visits;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Linq;

namespace Clinic.Interface.Doctors
{
    public partial class DoctorForm : ClinicForm
    {
        private long doctorId;
        private const int START_WORKING_HOUR = 8;
        private const int END_WORKING_HOUR = 16;
        private const int MINUTES_PER_VISIT = 15;
        private bool ShowedCurrentVisitsRecently = true;

        public DoctorForm(long _docId)
        {
            InitializeComponent();
            doctorId = _docId;
            refreshVisitsAtThisMoment();
        }

        private void refreshVisits()
        {
            var visits = VisitsService.GetInDate(DateTime.Now, doctorId); //ActiveUser.Id

            //this.gbVisits.g
            sourceDailyVisists.Clear();
            sourceDailyVisists.AddRange(visits.Select(v => new DailyVisit(v)));
            FillVisitsForScheduling(doctorId, DateTime.Now, 10);
        }

        private void FillVisitsForScheduling(long? doctorId, DateTime startTime, int numberOfVisits)
        {
            if (doctorId == null)
                return;

            var todayVisits = VisitsService.GetInDate(DateTime.Now, doctorId).Where(v => v.Status != VisitStatus.Removed.ToCode());
            var actualTime = startTime;

            for (int i = 0; i < numberOfVisits; i++)
            {
                var visit = todayVisits.SingleOrDefault(v => v.PlannedDate == actualTime);
                DailyVisit dailyVisit = null;
                if (visit == null)
                {
                    dailyVisit = new DailyVisit(actualTime);
                }
                else
                {
                    dailyVisit = new DailyVisit(visit);
                }

                sourceDailyVisists.Add(dailyVisit);
                actualTime = actualTime.AddMinutes(MINUTES_PER_VISIT);
            }
        }

        private void toolButtonRefresh_Click(object sender, System.EventArgs e)
        {
            refreshVisits();
        }

        private void clickShowVisitsAtThisMoment(object sender, EventArgs e)
        {
            ShowedCurrentVisitsRecently = true;
            refreshVisitsAtThisMoment();
        }

        private void refreshVisitsAtThisMoment()
        {
            sourceDailyVisists.Clear();

            DateTime roundedNow = new DateTime((DateTime.Now.Ticks / TimeSpan.FromMinutes(15).Ticks) * TimeSpan.FromMinutes(15).Ticks);
            FillVisitsForScheduling(doctorId, roundedNow, 10);
            System.Windows.Forms.MessageBox.Show("Visits refreshed (this moment)!");
        }

        private void refreshCurrentVisitsShowed(object sender, EventArgs e)
        {
            if (ShowedCurrentVisitsRecently)
            {
                refreshVisitsAtThisMoment();
            }
            else
            {
                refreshVisitsAtDay(monthCalendar1.SelectionStart, monthCalendar1.SelectionEnd);
            }
        }

        private void refreshVisitsAtDay(DateTime startSelection, DateTime endSelection)
        {
            sourceDailyVisists.Clear();

            var startTime = DateTime.Now.Date.AddHours(START_WORKING_HOUR);
            var endTime = DateTime.Now.Date.AddHours(END_WORKING_HOUR);
            var timeSpan = endTime - startTime;
            var numberOfVisits = (int)timeSpan.TotalMinutes / MINUTES_PER_VISIT;
            FillVisitsForScheduling(doctorId, startTime, numberOfVisits);

            System.Windows.Forms.MessageBox.Show("Visits refreshed (at some date)!");
        }
        

        private void dateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            ShowedCurrentVisitsRecently = false;
            refreshVisitsAtDay(e.Start, e.End);
        }
    }
}
