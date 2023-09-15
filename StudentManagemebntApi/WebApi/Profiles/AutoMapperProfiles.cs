using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DomainModels;
using DataModels=WebApi.DataModels;

namespace WebApi.Profiles
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student,Student>()
                .ReverseMap();
            CreateMap<DataModels.Gender, Gender>()
                .ReverseMap();
            CreateMap<DataModels.Address, Address>()
                .ReverseMap();
        }
    }
}
