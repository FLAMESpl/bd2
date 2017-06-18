﻿using Clinic.Facades.Visits;
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
            DateTime currently = DateTime.Now;
            DateTime currently2 = DateTime.Today;
            currently2 = currently2.AddHours(START_WORKING_HOUR);
            DateTime currently3 = DateTime.Today;
            currently3 = currently3.AddHours(END_WORKING_HOUR);

            if ((currently2 < currently) && (currently < currently3))
            {
                sourceDailyVisists.Clear();

                DateTime roundedNow = new DateTime((DateTime.Now.Ticks / TimeSpan.FromMinutes(15).Ticks) * TimeSpan.FromMinutes(15).Ticks);
                FillVisitsForScheduling(doctorId, roundedNow, 10);
                System.Windows.Forms.MessageBox.Show("Visits refreshed (this moment)!");
                monthCalendar1.SelectionStart = DateTime.Today;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show(
                    "Clinic is not operational now",
                    "Clinic is not operating at this hour.",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Warning
                    );
            }
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
            sourceDailyVisists.Clear();
            
            DateTime rangeStart;
            DateTime rangeEnd;
            if (startSelection.Hour == 0)
            {
                rangeStart = startSelection.AddHours(START_WORKING_HOUR);
                rangeEnd = startSelection.AddHours(END_WORKING_HOUR);
            }
            else // if startselection is equal to DateTime.Now, bc that has been called most recently
            {
                rangeStart = startSelection.AddHours(START_WORKING_HOUR) - startSelection.TimeOfDay;
                rangeEnd = rangeStart.AddHours(END_WORKING_HOUR - START_WORKING_HOUR);
            }
            
            var timeSpan = rangeEnd - rangeStart;
            var numberOfVisits = (int)timeSpan.TotalMinutes / MINUTES_PER_VISIT;
            FillVisitsForScheduling(doctorId, rangeStart, numberOfVisits);

            System.Windows.Forms.MessageBox.Show("Visits refreshed at "+startSelection.Day+ "/"+startSelection.Month+"/"+startSelection.Year+"!");
        }
        

        private void dateSelected(object sender, System.Windows.Forms.DateRangeEventArgs e)
        {
            //monthCalendar1.SelectionStart -= DateTime.Now.AddMilliseconds(DateTime.Now.TimeOfDay.Ticks);
            //monthCalendar1.SelectionEnd -= DateTime.Now.TimeOfDay.Ticks;
            //DateTime tmpdate = e.Start - DateTime.Now.TimeOfDay;
            ShowedCurrentVisitsRecently = false;
            refreshVisitsAtDay(monthCalendar1.SelectionStart/*SelectionStart*/);
        }

        private void clickShowDetailsAndActions(object sender, EventArgs e)
        {
            var detailsForm = new DetailsDoctorForm(datgridVisits);
            detailsForm.ShowDialog(ActiveUser);
        }
    }
}