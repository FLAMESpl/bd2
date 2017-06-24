using Clinic.Data;
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
    public partial class VisitForm : ClinicForm
    {
        private const int START_WORKING_HOUR = 8;
        private const int END_WORKING_HOUR = 16;
        private const int MINUTES_PER_VISIT = 15;

        private const string RESERVE_BUTTON = "Reserve";
        private const string CANCEL_BUTTON = "Cancel";
        private const string DELETE_BUTTON = "Delete";
        private const string EDIT_VISIT = "Edit";

        private Patient patient;
        private ActionType actionType;
        private PatientFilters patientFilters;

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
                patientFilters = new PatientFilters();
                groupBoxPatient.Controls.Add(patientFilters);

                dataGridViewDailyVisits.Columns.Remove(RESERVE_BUTTON);
            }

            monthCalendar.SelectionStart = DateTime.Now;
            monthCalendar.SelectionEnd = DateTime.Now;

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
                IdRegistrator = ActiveUser.Id,
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
            if (dailyVisit.Status == VisitStatus.Free)
                return;

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
            if (dailyVisit.Status == VisitStatus.Free)
                return;

            var result = MessageBox.Show($"Visit for patient {dailyVisit.Patient} will be deleted. Are you sure?", 
                null, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
                return;

            try
            {
                VisitsService.Delete(dailyVisit.VisitId.Value);
                if (actionType == ActionType.Browse)
                    bindingSourceDailyVisit.Remove(dailyVisit);
                else
                    dailyVisit.Delete();
            }
            catch(DomainException ex)
            {
                ex.ShowMessage();
            }
        }

        private void EditVisit(DailyVisit dailyVisit)
        {
            if (dailyVisit.VisitId == null)
                return;

            using (var form = new VisitDescriptionForm(dailyVisit))
            {
                string result = form.ShowDialog();
                if (result != null)
                    dailyVisit.Description = result;    
            }
        }

        private void FillVisits()
        {
            bindingSourceDailyVisit.Clear();

            var doctorId = ((DoctorListItem)listBoxDoctors.SelectedItem)?.Id;
            if (doctorId == 0)
                doctorId = null;
            
            if (actionType == ActionType.Browse)
            {
                FillVisitsForBrowsing(doctorId, monthCalendar.SelectionStart.Date, monthCalendar.SelectionEnd.Date, patientFilters.GetPatient());
            }
            else if (actionType == ActionType.Create)
            {
                var startTime = DateTime.Now.Date.AddHours(START_WORKING_HOUR);
                var endTime = DateTime.Now.Date.AddHours(END_WORKING_HOUR);
                var timeSpan = endTime - startTime;
                var numberOfVisits = (int)timeSpan.TotalMinutes / MINUTES_PER_VISIT;

                FillVisitsForScheduling(doctorId, startTime, numberOfVisits, monthCalendar.SelectionStart.Date, monthCalendar.SelectionEnd.Date);
            }
        }

        private void FillVisitsForBrowsing(long? doctorId, DateTime firstDay, DateTime lastDay, Patient patientSearchCriteria)
        {
            var excludedStatuses = new VisitStatus[] { VisitStatus.Removed };
            var visits = VisitsService.GetInDateRange(firstDay, lastDay, doctorId, patientSearchCriteria, excludedStatuses);
            bindingSourceDailyVisit.AddRange(visits.Select(v => new DailyVisit(v)));
        }

        private void FillVisitsForScheduling(long? doctorId, DateTime startTime, int numberOfVisitsPerDay, DateTime firstDay, DateTime lastDay)
        {
            if (doctorId == null)
                return;

            var excludedStatuses = new VisitStatus[] { VisitStatus.Removed, VisitStatus.Cancelled };
            var todayVisits = VisitsService.GetInDateRange(firstDay, lastDay, doctorId, null, excludedStatuses);
            var actualDay = firstDay;

            for (int j = 0; j < (lastDay - firstDay).Days + 1; j++)
            {
                var actualTime = actualDay + startTime.TimeOfDay;
                for (int i = 0; i < numberOfVisitsPerDay; i++)
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
                actualDay = actualDay.AddDays(1);
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
                case EDIT_VISIT:
                    EditVisit((DailyVisit)bindingSourceDailyVisit.Current);
                    break;
                default:
                    return;
            }

            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewDailyVisits.RowCount)
                grid.InvalidateRow(e.RowIndex);
        }

        private void toolButtonRefresh_Click(object sender, EventArgs e)
        {
            FillVisits();
        }
    }
}
