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

            return _mapper.Map<List<PollDto>>(poll); 
        }

        public PollDto GetPoll(int id)
        {
            var poll = _pollRepository.GetById(id);

            return _mapper.Map<PollDto>(poll);
        }

        public List<User> GetUsersFromPoll(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePoll(PollDto dto)
        {
            return _pollRepository.Update(_mapper.Map<Poll>(dto));

        }
    }
}
