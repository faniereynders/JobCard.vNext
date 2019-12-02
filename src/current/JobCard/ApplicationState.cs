using JobCard.Application.UI;
using JobCard.Core;
using Reytec.JobCard.Core;
using System;
using System.Windows.Forms;

namespace JobCard
{
    public static class ApplicationState
    {
        public static Main MainForm;
        public static Uri AuthorizationCallbackUri;
        public static IntPtr LoginWindowHandle;
        public static ApplicationUser User { get; set; }
        public static OrganizationEntity Organization { get; internal set; }
    }
    
}
