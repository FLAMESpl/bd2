using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic.Interface.Common.Helpers
{
    public static class BindingSourceExtensions
    {
        public static void AddRange(this BindingSource bindingSource, IEnumerable<object> objects)
        {
            foreach (var obj in objects)
            {
                bindingSource.Add(obj);
            }
        }
    }
}
