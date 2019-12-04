using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobCard.Infrastructure.MappingProfiles
{
    public class OrganizationProfile: MappingProfile
    {
        public OrganizationProfile()
        {
            CreateMap<Microsoft.Graph.Organization, JobCard.Core.OrganizationEntity>();
        }
    }
}
