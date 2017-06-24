using Clinic.Data;
using Clinic.Facades.Common;
using System.Linq;

namespace Clinic.Facades.Visits
{
    public static class VisitExtensions
    {
        public static void AssertIsNotOverlappingWithAnotherVisit(this Visit visit, IQueryable<Visit> visits)
        {
            var removedStatus = VisitStatus.Removed.ToCode();
            var cancelledStatus = VisitStatus.Cancelled.ToCode();
            foreach (var v in visits)
            {
                if (v.Status != removedStatus && v.Status != cancelledStatus && v.PlannedDate == visit.PlannedDate)
                {
                    if (v.IdDoctor == visit.IdDoctor)
                    {
                        throw new DomainException("Doctor already has scheduled visit for this hour");
                    }
                    else if (v.IdPatient == visit.IdPatient)
                    {
                        throw new DomainException("Patient already has scheduled visit for this hour");
                    }
                }
            }
        }
    }
}
