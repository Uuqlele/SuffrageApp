using Core.Entities;
using Core.Interfaces.IRepositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class PollRepository : EfRepository<Poll>, IPollRepository
    {
        public PollRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
