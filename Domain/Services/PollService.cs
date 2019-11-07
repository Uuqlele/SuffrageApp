using AutoMapper;
using Core.Entities;
using Core.Interfaces.IRepositories;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class PollService : IPollService
    {
        private readonly IMapper _mapper;
        private readonly IPollRepository _pollRepository;

        public PollService(IMapper mapper, IPollRepository pollRepository)
        {
            _mapper = mapper;
            _pollRepository = pollRepository;
        }

        public List<PollDto> GetAllPolls()
        {
            var poll = _pollRepository.GetAll();

            return _mapper.Map<List<PollDto>>(poll) ?? new List<PollDto>(); 
        }

        /// <summary>
        /// Получить опрос по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор опроса</param>
        /// <returns></returns>
        public PollDto GetPoll(int id)
        {
            var poll = _pollRepository.GetById(id);

            return _mapper.Map<PollDto>(poll) ?? new PollDto();
        }

        public List<User> GetUsersFromPoll(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Создание опроса 
        /// </summary>
        /// <param name="dto">Временная сущность создаваемого опроса</param>
        /// <returns>Идентификатор созданного опроса</returns>
        public int CreatePollAndGetId(PollDto dto)
        {
             return _pollRepository.Add(_mapper.Map<Poll>(dto));
        }

        public bool UpdatePoll(PollDto dto)
        {
            try
            {
                _pollRepository.Update(_mapper.Map<Poll>(dto));
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool DeletePoll(int id)
        {
            try
            {
                _pollRepository.Delete(id);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
