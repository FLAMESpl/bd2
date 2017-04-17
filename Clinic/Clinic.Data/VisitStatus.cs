namespace Clinic.Data
{
    public enum VisitStatus
    {
        Scheduled,
        Finalised,
        Cancelled,
        Removed,
        Unknown
    }

    public static class VisitStatusExtensions
    {
        public static VisitStatus GetFromCode(string code)
        {
            switch (code)
            {
                case "SCHEDULED":
                    return VisitStatus.Scheduled;
                case "CANCELLED":
                    return VisitStatus.Cancelled;
                case "FINALISED":
                    return VisitStatus.Finalised;
                case "REMOVED":
                    return VisitStatus.Removed;
                default:
                    return VisitStatus.Unknown;
            }
        }
    }

}
