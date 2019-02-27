using AutoMapper;
using JobcardCloud.CustomerManagement.Commands;
using JobcardCloud.CustomerManagement.Entities;
using JobcardCloud.CustomerManagement.Models;
using Microsoft.Azure.Documents;
using System;

namespace JobcardCloud.Customers.Mappings
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CreatePersonCustomerCommand, PersonCustomerEntity>();
            CreateMap<Document, CustomerModel>();
            // CreateMap<NewCompanyCustomerModel, CompanyCustomerEntity>()
            //     .ForMember(d => d.PartitionKey, o => o.MapFrom(s => s.TenantId))
            //     .ForMember(d => d.RowKey, o => o.MapFrom(s => Guid.NewGuid().ToString()));
        }
    }
}
