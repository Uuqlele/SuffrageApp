using AutoMapper;
using Core.Dtos;
using Core.Entities;
using Core.Interfaces.IRepositories;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IMapper _mapper;
        private readonly IAnswerRepository _answerRepository;

        public AnswerService(IMapper mapper, IAnswerRepository answerRepository)
        {
            _mapper = mapper;
            _answerRepository = answerRepository;
        }

        public void Create(AnswerDto answer)
        {
            _answerRepository.Add(_mapper.Map<Answer>(answer));
        }

        public List<AnswerDto> GetAnswersByPoll(int id)
        {
            throw new NotImplementedException();
        }

        public List<AnswerDto> GetAnswersByUser(int id)
        {
            throw new NotImplementedException();
        }

        public bool ValidateAnswer(AnswerDto answer)
        {

            return false;
        }
    }
}
