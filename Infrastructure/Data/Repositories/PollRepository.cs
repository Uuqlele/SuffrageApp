using Core.Entities;
using Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class PollRepository : EfRepository<Poll>, IPollRepository
    {
        public PollRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
