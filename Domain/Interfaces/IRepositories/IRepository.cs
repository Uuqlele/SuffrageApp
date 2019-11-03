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
        void Add(T entity);
        void Update(T entity);
        bool Delete(int id);
    }
}
