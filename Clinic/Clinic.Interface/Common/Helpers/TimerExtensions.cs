using System.Windows.Forms;

namespace Clinic.Interface.Common.Helpers
{
    public static class TimerExtensions
    {
        public static void Reset(this Timer timer)
        {
            timer.Stop();
            timer.Start();
        }
    }
}
