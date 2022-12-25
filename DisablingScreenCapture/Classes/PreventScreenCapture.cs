using System;
using System.Runtime.InteropServices;

namespace DisablingScreenCapture.Classes
{
    public class PreventScreenCapture
    {
        [DllImport("user32.dll")]
        public static extern uint SetWindowDisplayAffinity(IntPtr hwnd, uint dwAffinity);

        public static void ProtectScreen(IntPtr window)
        {
            const uint WDA_NONE = 0;
            const uint WDA_MONITOR = 1;
            SetWindowDisplayAffinity(window, WDA_MONITOR);
        }
    }
}
