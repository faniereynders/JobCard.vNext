// Decompiled with JetBrains decompiler
// Type: Reytec.JobCard.Core.Main
// Assembly: JobCard, Version=1.0.0.2, Culture=neutral, PublicKeyToken=null
// MVID: 355A629F-A2FA-4599-879B-59162A296DD0
// Assembly location: C:\dev\Reytec JobCard\Reytec JobCard\JobCard.exe

namespace Reytec.JobCard.Core
{
    public class AzureADOrganizationsDto
    {
        public AzureADOrganizationDto[] Value { get; set; }
        public class AzureADOrganizationDto
        {
            public string Id { get; set; }
            public string DisplayName { get; set; }
        }
    }
}