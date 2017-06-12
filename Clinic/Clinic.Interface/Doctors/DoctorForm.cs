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
            Console.WriteLine("DoctorForm\tCalendar: " + monthCalendar1.SelectionStart);
        }

        private void refreshVisits()
        {
            var visits = VisitsService.GetInDate(DateTime.Now, doctorId); //ActiveUser.Id

            //this.gbVisits.g
            sourceDailyVisists.Clear();
            sourceDailyVisists.AddRange(visits.Select(v => new DailyVisit(v)));
            FillVisitsForScheduling(doctorId, DateTime.Now, 10);
            Console.WriteLine("RefreshVisits\tCalendar: " + monthCalendar1.SelectionStart);
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
            monthCalendar1.SelectionStart = DateTime.Today;
            Console.WriteLine("AtThisMoment\tCalendar: " + monthCalendar1.SelectionStart);
        }

        private void refreshCurrentVisitsShowed(object sender, EventArgs e)
        {
            if (ShowedCurrentVisitsRecently)
            {
                refreshVisitsAtThisMoment();
            }
            else
            {
                refreshVisitsAtDay(monthCalendar1.SelectionStart);
            }
        }

        private void refreshVisitsAtDay(DateTime startSelection)
        {
            Console.WriteLine("AtDay1\t\tCalendar: " + monthCalendar1.SelectionStart);
            sourceDailyVisists.Clear();

            //var startTime = DateTime.Now.Date.AddHours(START_WORKING_HOUR);
            Console.WriteLine("startSelection for day:"); //12:10?
            Console.WriteLine(startSelection);
            DateTime rangeStart = startSelection.AddHours(START_WORKING_HOUR);
            DateTime rangeEnd = startSelection.AddHours(END_WORKING_HOUR);
            //var endTime = DateTime.Now.Date.AddHours(END_WORKING_HOUR);
            var timeSpan = rangeEnd - rangeStart;
            var numberOfVisits = (int)timeSpan.TotalMinutes / MINUTES_PER_VISIT;
            FillVisitsForScheduling(doctorId, rangeStart, numberOfVisits);
            Console.WriteLine("AtDay2\t\tCalendar: " + monthCalendar1.SelectionStart);

            System.Windows.Forms.MessageBox.Show("Visits refreshed (at some date)!");
        }
        

        private void dateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            //monthCalendar1.SelectionStart -= DateTime.Now.AddMilliseconds(DateTime.Now.TimeOfDay.Ticks);
            //monthCalendar1.SelectionEnd -= DateTime.Now.TimeOfDay.Ticks;
            //DateTime tmpdate = e.Start - DateTime.Now.TimeOfDay;
            Console.WriteLine("dateSelected\tCalendar: " + monthCalendar1.SelectionStart);
            ShowedCurrentVisitsRecently = false;
            Console.WriteLine(e.End);
            refreshVisitsAtDay(monthCalendar1.SelectionStart/*SelectionStart*/);
        }

        private void clickShowDetailsAndActions(object sender, EventArgs e)
        {
            var detailsForm = new DetailsDoctorForm(datgridVisits);
            detailsForm.ShowDialog(ActiveUser);
        }
    }
}
