using System;

namespace Clinic.Data.Helpers
{
    public static class DataContextFactory
    {
        public static ClinicDataContext Create()
        {
            return new ClinicDataContext();
        }

        public static ClinicDataContext Create(Action<DataContextLoaderDescriptor> include)
        {
            var dataContext = Create();
            var dataContextLoaderDescriptor = new DataContextLoaderDescriptor();

            include.Invoke(dataContextLoaderDescriptor);
            dataContext.LoadOptions = dataContextLoaderDescriptor.LoadOptions;

            return dataContext;
        }
    }
}
