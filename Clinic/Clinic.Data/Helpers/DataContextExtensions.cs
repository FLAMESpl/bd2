using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;

namespace Clinic.Data.Helpers
{
    public static class DataContextExtensions
    {
        public static void AttachAndDelete<T>(this Table<T> entitySet, IEnumerable<T> entities) where T : class
        {
            entitySet.AttachAll(entities);
            entitySet.DeleteAllOnSubmit(entities);
        }
    }
}
