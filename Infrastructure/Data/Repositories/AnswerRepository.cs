using Core.Entities;
using Core.Interfaces.IRepositories;

namespace Infrastructure.Data.Repositories
{
    public class AnswerRepository : EfRepository<Answer>, IAnswerRepository
    {
        public AnswerRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
