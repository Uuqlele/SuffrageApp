using Core.Entities;
using Core.Interfaces.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class PollRepository : EfRepository<Poll>, IPollRepository
    {
        private readonly AppDbContext _dbContext;

        public PollRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public int GetPollsCount()
        {
            return _dbContext.Polls.Count();
        }

        public List<Poll> GetPollsPage(int pollOnPage, int page)
        {
            return _dbContext.Polls.Skip((page - 1) * pollOnPage).Take(pollOnPage).ToList();
        }

        public Poll GetPollWithOptions(int id)
        {
            return _dbContext.Polls
                .Include(poll => poll.Options)
                .SingleOrDefault(poll => poll.Id == id);
        }
    }
}
