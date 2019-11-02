using Core.Entities;
using Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        List<T> GetAll();
        T Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
