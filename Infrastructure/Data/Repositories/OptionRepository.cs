using Core.Entities;
using Core.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Data.Repositories
{
    public class OptionRepository : EfRepository<Option>, IOptionRepository
    {
        private readonly AppDbContext _dbContext;

        public OptionRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Option GetOptionByText(string optionText)
        {
            var result = _dbContext.Options.Where(option => option.Text.Equals(optionText)).ToList();

            if (result.Count > 1)
            {
                throw new Exception("Вариантов ответа с таким текстом несколько.");
            }

            return result.FirstOrDefault();
        }
    }
}
