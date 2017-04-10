namespace Clinic.Data
{
    public enum VisitStatus
    {
        Abandoned,
        Reserved,
        Commised,
        Unknown
    }

    public static class VisitStatusExtensions
    {
        public static VisitStatus GetFromCode(string code)
        {
            switch (code)
            {
                case "ABANDONED":
                    return VisitStatus.Abandoned;
                case "RESERVED":
                    return VisitStatus.Reserved;
                case "COMMISED":
                    return VisitStatus.Commised;
                default:
                    return VisitStatus.Unknown;
            }
        }
    }

}
