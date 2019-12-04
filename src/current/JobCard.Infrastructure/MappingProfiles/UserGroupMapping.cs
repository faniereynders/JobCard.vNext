using System;
using System.Collections.Generic;
using System.Text;

namespace JobCard.Infrastructure.MappingProfiles
{
    public class UserGroupMapping: MappingProfile
    {
        public UserGroupMapping()
        {
            CreateMap<Microsoft.Graph.Group, JobCard.Core.UserGroup>();
        }
    }
}
