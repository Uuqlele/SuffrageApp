using AutoMapper;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Mapping
{
    public class PollProfile : Profile
    {
        public PollProfile()
        {
            CreateMap<PollDto, Poll>(); //TODO: Dto и маппинг
            CreateMap<Poll, PollDto>();
        }
    }
}
