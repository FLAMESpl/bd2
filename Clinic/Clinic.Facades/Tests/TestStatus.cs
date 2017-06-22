namespace Clinic.Facades.Tests
{
    public enum TestStatus
    {
        Scheduled,
        Executed,
        CancelledByAssistant,
        CancelledByManager,
        Approved,
        Unknown
    }

    public static class TestStatusExtensions
    {
        public static TestStatus GetFromCode(string code)
        {
            switch (code)
            {
                case "SCH":
                    return TestStatus.Scheduled;
                case "EXE":
                    return TestStatus.Executed;
                case "CBA":
                    return TestStatus.CancelledByAssistant;
                case "CBM":
                    return TestStatus.CancelledByManager;
                case "APP":
                    return TestStatus.Approved;
                default:
                    return TestStatus.Unknown;
            }
        }

        public static string ToCode(this TestStatus ts)
        {
            switch (ts)
            {
                case TestStatus.Scheduled:
                    return "SCH";
                case TestStatus.Executed:
                    return "EXE";
                case TestStatus.CancelledByAssistant:
                    return "CBA";
                case TestStatus.CancelledByManager:
                    return "CBM";
                case TestStatus.Approved:
                    return "APP";
                default:
                    return "";
            }
        }
    }

}
