using System;
using System.Data.Linq;
using System.Linq.Expressions;

namespace Clinic.Data.Helpers
{
    public class DataContextLoaderDescriptor
    {
        private DataLoadOptions loadOptions = new DataLoadOptions();
        public DataLoadOptions LoadOptions => loadOptions;

        public DataContextLoaderDescriptor Include<T>(Expression<Func<T, object>> selector)
        {
            loadOptions.LoadWith(selector);
            return this;
        }
    }
}
