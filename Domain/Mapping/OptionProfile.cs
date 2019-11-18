using AutoMapper;
using Core.Dtos;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Mapping
{
    public class OptionProfile : Profile
    {
        public OptionProfile()
        {
            CreateMap<OptionDto, Option>();
            CreateMap<Option, OptionDto>();
        }
    }
}
