using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces.IRepositories
{
    public interface IPollRepository : IRepository<Poll>
    {
        int GetPollsCount();
        public List<Poll> GetPollsPage(int pollOnPage, int page);
        Poll GetPollWithOptions(int id);
    }
}
