using AutoMapper;
using Core.Entities;
using Core.Enums;
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
        private readonly IOptionRepository _optionRepository;

        public PollService(IMapper mapper, IPollRepository pollRepository, IOptionRepository optionRepository)
        {
            _mapper = mapper;
            _pollRepository = pollRepository;
            _optionRepository = optionRepository;
        }

        public List<PollDto> GetPollsPage()
        {

            var polls = _mapper.Map<List<PollDto>>(_pollRepository.GetAll());

            polls.ForEach(poll => poll.State = GetPollState(poll));

            return polls ?? new List<PollDto>(); 
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

        private StateEnum GetPollState(PollDto poll)
        {
            //Если дата начала в прошлом - опрос начался, иначе дата начала в будущем и опрос ещё не начался
            StateEnum result = poll.StartDate <= DateTime.Now ? StateEnum.Active : StateEnum.NotStarted;

            if (poll.EndDate <= DateTime.Now) //Если дата конца в прошлом - опрос закончился
            {
                result = StateEnum.Ended;
            }
            return result;
        }

        public int GetPollsCount()
        {
            return _pollRepository.GetPollsCount();
        }
    }
}
