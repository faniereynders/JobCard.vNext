using AutoMapper;
using JobcardCloud.CustomerManagement.Entities;
using JobcardCloud.CustomerManagement.Models;
using System;

namespace JobcardCloud.Customers.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<NewPersonCustomerModel, PersonCustomerEntity>()
                .ForMember(d => d.PartitionKey, o => o.MapFrom(s => s.TenantId))
                .ForMember(d => d.RowKey, o => o.MapFrom(s => Guid.NewGuid().ToString()));
            CreateMap<NewCompanyCustomerModel, CompanyCustomerEntity>()
                .ForMember(d => d.PartitionKey, o => o.MapFrom(s => s.TenantId))
                .ForMember(d => d.RowKey, o => o.MapFrom(s => Guid.NewGuid().ToString()));
        }
    }
}
