using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using WebApplication75.DTO;
using WebApplication75.Models;
namespace WebApplication75.App_Start
{
    public class MappingProfile:Profile 
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDTO>();
            Mapper.CreateMap<CustomerDTO, Customer>();
        }
    }
}