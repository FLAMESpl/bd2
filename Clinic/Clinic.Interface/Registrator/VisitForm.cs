using Clinic.Data;
using Clinic.Facades.Doctors;
using Clinic.Facades.Visits;
using Clinic.Interface.Common;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Clinic.Interface.Registrator
{
    public partial class VisitForm : Form
    {
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
            }

            FillVisits(DateTime.Now.Date.AddHours(8), DateTime.Now.Date.AddHours(16), 15);
            FillDoctors();
        }

        private void ReserveVisit(DailyVisit dailyVisit)
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

            VisitsService.Add(visit);
        }

        private void FillVisits(DateTime startTime, DateTime endTime, int minutesPerVisit)
        {
            var todayVisits = VisitsService.GetInDate(DateTime.Now);

            var timeSpan = endTime - startTime;
            var numberOfVisits = timeSpan.TotalMinutes / minutesPerVisit;

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
                actualTime = actualTime.AddMinutes(minutesPerVisit);
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
                case "Reserve":
                    ReserveVisit((DailyVisit)bindingSourceDailyVisit.Current);
                    break;
                default:
                    break;
            }
        }
    }
}
