using System.Collections.Generic;

namespace JobCard.Core
{
    public class ApplicationUser
    {
        public string Id { get; set; }
        public string DisplayName { get; set; }
        public IEnumerable<UserGroup> Groups { get; set; }

    }
}