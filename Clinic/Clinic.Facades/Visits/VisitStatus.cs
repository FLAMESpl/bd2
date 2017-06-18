namespace Clinic.Facades.Visits
{
    public enum VisitStatus
    {
        Free,
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
                case "FRE":
                    return VisitStatus.Free;
                case "SCH":
                    return VisitStatus.Scheduled;
                case "CAN":
                    return VisitStatus.Cancelled;
                case "FIN":
                    return VisitStatus.Finalised;
                case "REM":
                    return VisitStatus.Removed;
                default:
                    return VisitStatus.Unknown;
            }
        }

        public static string ToCode(this VisitStatus visit)
        {
            switch (visit)
            {
                case VisitStatus.Free:
                    return "FRE";
                case VisitStatus.Scheduled:
                    return "SCH";
                case VisitStatus.Finalised:
                    return "FIN";
                case VisitStatus.Cancelled:
                    return "CAN";
                case VisitStatus.Removed:
                    return "REM";
                default:
                    return "";
            }
        }
    }

}
