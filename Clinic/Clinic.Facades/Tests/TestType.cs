namespace Clinic.Facades.Tests
{
    public enum TestType
    {
        Laboratory,
        Physical,
        Unknown
    }

    public static class TestTypeExtensions
    {
        public static TestType GetFromCode(string code)
        {
            switch (code)
            {
                case "L":
                    return TestType.Laboratory;
                case "P":
                    return TestType.Physical;
                default:
                    return TestType.Unknown;
            }
        }

        public static string ToCode(this TestType tt)
        {
            switch (tt)
            {
                case TestType.Physical:
                    return "P";
                case TestType.Laboratory:
                    return "L";
                default:
                    return "";
            }
        }
    }
}
