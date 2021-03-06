﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FileArchive.Core
{
    public interface IGenericRepository<T,TId> where T : class
    {
        T Add(T entity);
        Task<T> AddAsync(T entity);
        int Count();
        Task<int> CountAsync();
        void Delete(T entity);
        //Task<int> DeleteAsync(T entity);
        void Dispose();
        T Find(Expression<Func<T, bool>> match);
        ICollection<T> FindAll(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);
        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<ICollection<T>> FindByAsync(Expression<Func<T, bool>> predicate);
        T Get(TId id);
        IQueryable<T> GetAll();
        Task<ICollection<T>> GetAllAsync();
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetAsync(TId id);
        //void Save();
        //Task<int> SaveAsync();
        T Update(T entity, TId key);
        Task<T> UpdateAsync(T entity, TId key);
    }
}
