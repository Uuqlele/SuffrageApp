using AutoMapper;
using Core.Dtos;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Mapping
{
    public class AnswerProfile : Profile
    {
        public AnswerProfile()
        {
            CreateMap<AnswerDto, Answer>(); 
            CreateMap<Answer, AnswerDto>();
        }
    }
}
