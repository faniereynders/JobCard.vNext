using AutoMapper;
using JobCard.Core;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobCard.Infrastructure.MappingProfiles
{
    public class ApplicationUserProfile : MappingProfile
    {
        public ApplicationUserProfile()
        {
            CreateMap<Tuple<Microsoft.Graph.User, IEnumerable<Microsoft.Graph.Group>>, JobCard.Core.ApplicationUser>()
                .ForMember(m => m.Id, c => c.MapFrom(s => s.Item1.Id))
                .ForMember(m => m.DisplayName, c => c.MapFrom(s => s.Item1.DisplayName))
                .ForMember(m => m.Groups, c => c.MapFrom(s => s.Item2));

        }
    }


}
