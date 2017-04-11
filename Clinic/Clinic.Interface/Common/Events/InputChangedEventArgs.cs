using System;

namespace Clinic.Interface.Common.Events
{
    public class InputChangedEventArgs : EventArgs
    {
        public string Text { get; private set; }

        public InputChangedEventArgs(string text)
        {
            Text = text;
        }
    }
}
