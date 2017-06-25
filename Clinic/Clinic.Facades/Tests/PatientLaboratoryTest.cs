using Clinic.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Facades.Tests
{
    public class PatientLaboratoryTest
    {
        public long Id
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string Surname
        {
            get; set;
        }
        public string Test
        {
            get; set;
        }
        public DateTime CommissionDate
        {
            get; set;
        }
        public string DoctorNotes
        {
            get; set;
        }
        public DateTime? ExecutionDate
        {
            get; set;
        }
        public string Result
        {
            get; set;
        }
    }
}
