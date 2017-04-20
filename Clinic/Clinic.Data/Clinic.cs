using System;
using System.Data.Linq.Mapping;
using System.Reflection;

namespace Clinic.Data
{
    partial class ClinicDataContext
    {
        [Function(Name = "GetDate", IsComposable = true)]
        public DateTime GetSystemDate()
        {
            var methodInfo = MethodBase.GetCurrentMethod() as MethodInfo;
            var parameters = new object[] { };
            return (DateTime)ExecuteMethodCall(this, methodInfo, parameters).ReturnValue;
        }
    }
}