using Core.Dtos;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.Services
{
    public interface IAnswerService
    {
        void Create(AnswerDto answer);

        List<AnswerDto> GetAnswersByUser(int id);
        List<AnswerDto> GetAnswersByPoll(int id);
    }
}
