using System;

namespace JobCard
{
    public static class ApplicationState
    {
        public static Uri AuthorizationCallbackUri;
        public static IntPtr LoginWindowHandle;
        public static ApplicationUser User { get; set; }
        public static Organization Organization { get; internal set; }
    }
}
