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
            return _dbContext.Polls
                .OrderByDescending(poll => poll.Id)
                .Skip((page - 1) * pollOnPage)
                .Take(pollOnPage)
                .ToList();
        }

        public Poll GetPollWithOptions(int id)
        {
            return _dbContext.Polls
                .Include(poll => poll.Options)
                .SingleOrDefault(poll => poll.Id == id);
        }

        public void UpdatePollWithOptions(Poll pollForUpdate)
        {
            var existingPoll = _dbContext.Polls
                .Where(p => p.Id == pollForUpdate.Id)
                .Include(p => p.Options)
                .SingleOrDefault();

            if (existingPoll != null)
            {
                // Update parent
                _dbContext.Entry(existingPoll).CurrentValues.SetValues(pollForUpdate);

                // Delete children
                foreach (var existingChild in existingPoll.Options.ToList())
                {
                    if (!pollForUpdate.Options.Any(c => c.Id == existingChild.Id))
                        _dbContext.Options.Remove(existingChild);
                }

                // Update and Insert children
                foreach (var option in pollForUpdate.Options)
                {

                    if (option.Id != 0)
                        // Update child
                        _dbContext.Entry(option).CurrentValues.SetValues(option);
                    else
                    {
                        // Insert child
                        var newChild = new Option
                        {

                            Text = option.Text,
                            Poll = option.Poll
                        };
                        existingPoll.Options.Add(newChild);
                    }
                }

                _dbContext.SaveChanges();
            }
        }
    }
}
