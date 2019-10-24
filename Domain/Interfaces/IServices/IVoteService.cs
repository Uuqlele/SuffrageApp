using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.Services
{
    public interface IVoteService
    {
        List<Vote> GetVotesByUser(int id);
        List<Vote> GetVotesByPoll(int id);
    }
}
