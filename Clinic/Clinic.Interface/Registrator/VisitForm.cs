﻿using Clinic.Data;
using Clinic.Facades.Common;
using Clinic.Facades.Doctors;
using Clinic.Facades.Patients;
using Clinic.Facades.Visits;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class VisitForm : Form
    {
        private const int START_WORKING_HOUR = 8;
        private const int END_WORKING_HOUR = 16;
        private const int MINUTES_PER_VISIT = 15;

        private const string RESERVE_BUTTON = "Reserve";
        private const string CANCEL_BUTTON = "Cancel";
        private const string DELETE_BUTTON = "Delete";

        private Patient patient;
        private ActionType actionType;

        public VisitForm()
        {
            InitializeComponent();
        }

        public VisitForm(Patient patient, ActionType actionType)
        {
            InitializeComponent();

            this.actionType = actionType;
            this.patient = patient;

            if (actionType == ActionType.Create)
            {
                var label = new Label
                {
                    AutoSize = false,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Text = $"{patient.Name} {patient.Surname}",
                    Font = new Font(FontFamily.GenericSansSerif, 14f)
                };

                groupBoxPatient.Controls.Add(label);
            }
            else if (actionType == ActionType.Browse)
            {
                var patientFilters = new PatientFilters();
                groupBoxPatient.Controls.Add(patientFilters);

                dataGridViewDailyVisits.Columns.Remove(RESERVE_BUTTON);
            }

            FillVisits();
            FillDoctors();
        }

        private void ScheduleVisit(DailyVisit dailyVisit)
        {
            var doctor = (DoctorListItem)listBoxDoctors.SelectedItem;
            if (doctor == null || doctor.Empty)
            {
                MessageBox.Show("Can not reserve a visit without selected doctor", "Missing doctor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var visit = new Visit
            {
                Description = "",
                Diagnosis = null,
                IdDoctor = doctor.Id,
                IdPatient = patient.Id,
                IdRegistrator = 1,
                PlannedDate = dailyVisit.VisitHour,
                RegistrationDate = DateTime.Now,
                ResolutionDate = null,
                Status = VisitStatus.Scheduled.ToCode()
            };
            
            try
            {
                var createdId = VisitsService.Add(visit);
                dailyVisit.Reserve(createdId, doctor.Name, patient.GetFullName());
            }
            catch (DomainException ex)
            {
                ex.ShowMessage();
            }
        }

        private void CancelVisit(DailyVisit dailyVisit)
        {
            try
            {
                VisitsService.Cancel(dailyVisit.VisitId.Value);
                dailyVisit.Cancel();
            }
            catch (DomainException ex)
            {
                ex.ShowMessage();
            }
        }

        private void DeleteVisit(DailyVisit dailyVisit)
        {
            var result = MessageBox.Show($"Visit for patient {dailyVisit.Patient} will be deleted. Are you sure?", 
                null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            try
            {
                VisitsService.Delete(dailyVisit.VisitId.Value);
                dailyVisit.Delete();
            }
            catch(DomainException ex)
            {
                ex.ShowMessage();
            }
        }

        private void FillVisits()
        {
            bindingSourceDailyVisit.Clear();

            var doctorId = ((DoctorListItem)listBoxDoctors.SelectedItem)?.Id;

            var startTime = DateTime.Now.Date.AddHours(START_WORKING_HOUR);
            var endTime = DateTime.Now.Date.AddHours(END_WORKING_HOUR);
            var timeSpan = endTime - startTime;
            var numberOfVisits = (int)timeSpan.TotalMinutes / MINUTES_PER_VISIT;

            if (actionType == ActionType.Browse)
            {
                FillVisitsForBrowsing(doctorId, startTime, numberOfVisits);
            }
            else if (actionType == ActionType.Create)
            {
                FillVisitsForScheduling(doctorId, startTime, numberOfVisits);
            }
        }

        private void FillVisitsForBrowsing(long? doctorId, DateTime startTime, int numberOfVisits)
        {
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

                bindingSourceDailyVisit.Add(dailyVisit);
                actualTime = actualTime.AddMinutes(MINUTES_PER_VISIT);
            }
        }

        private void FillDoctors()
        {
            if (actionType == ActionType.Browse)
                listBoxDoctors.Items.Add(new DoctorListItem());

            var doctors = DoctorsService.GetAll().Select(d => new DoctorListItem(d));
            listBoxDoctors.Items.AddRange(doctors.ToArray());
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridViewDailyVisits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = sender as DataGridView;
            var columnName = grid.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case RESERVE_BUTTON:
                    ScheduleVisit((DailyVisit)bindingSourceDailyVisit.Current);
                    break;
                case CANCEL_BUTTON:
                    CancelVisit((DailyVisit)bindingSourceDailyVisit.Current);
                    break;
                case DELETE_BUTTON:
                    DeleteVisit((DailyVisit)bindingSourceDailyVisit.Current);
                    break;
                default:
                    break;
            }

            grid.InvalidateRow(e.RowIndex);
        }

        private void listBoxDoctors_SelectedValueChanged(object sender, EventArgs e)
        {
            FillVisits();
        }
    }
}