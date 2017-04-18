using System.Collections;
using System.Collections.Generic;

namespace Clinic.Interface.Common.Helpers
{
    public static class CollectionsExtensions
    {
        public static void AddRange(this IList list, IEnumerable<object> objects)
        {
            foreach (var @object in objects)
            {
                list.Add(@object);
            }
        }
    }
}
