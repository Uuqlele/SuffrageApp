﻿using System;
using System.Collections.Generic;
using System.Linq;
using Core.Interfaces;
using Core.SharedKernel;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _dbContext;

        public EfRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T GetById(int id) 
        {
            return _dbContext.Set<T>().SingleOrDefault(e => e.Id == id);
        }

        public List<T> GetAll() 
        {
            return _dbContext.Set<T>().ToList();
        }

        public void Add(T entity) 
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();
        }

        public bool Delete(int id) 
        {
            var entity = GetById(id);
            _dbContext.Set<T>().Remove(entity);
            
            return _dbContext.SaveChanges() == 0 ? false : true;
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
             _dbContext.SaveChanges();
        }
    }
}
