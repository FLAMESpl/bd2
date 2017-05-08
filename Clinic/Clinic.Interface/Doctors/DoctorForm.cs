using Clinic.Facades.Visits;
using Clinic.Interface.Common;
using Clinic.Interface.Common.Helpers;
using System;
using System.Linq;

namespace Clinic.Interface.Doctors
{
    public partial class DoctorForm : ClinicForm
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void RefreshVisits()
        {
            var visits = VisitsService.GetInDate(DateTime.Now, ActiveUser.Id);
            sourceDailyVisists.Clear();
            sourceDailyVisists.AddRange(visits.Select(v => new DailyVisit(v)));
        }

        private void toolButtonRefresh_Click(object sender, System.EventArgs e)
        {
            RefreshVisits();
        }
    }
}
