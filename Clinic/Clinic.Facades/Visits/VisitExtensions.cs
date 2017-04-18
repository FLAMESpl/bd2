using Clinic.Data;
using System.Linq;

namespace Clinic.Facades.Visits
{
    public static class VisitExtensions
    {
        public static bool HasOverlappingWith(this IQueryable<Visit> visits, Visit visit)
        {
            return visits.Any(v => v.PlannedDate == visit.PlannedDate && v.IdDoctor == visit.IdDoctor);
        }
    }
}
