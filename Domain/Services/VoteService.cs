using Core.Entities;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Services
{
    public class VoteService : IVoteService
    {
        public List<Vote> GetVotesByPoll(int id)
        {
            throw new NotImplementedException();
        }

        public List<Vote> GetVotesByUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
