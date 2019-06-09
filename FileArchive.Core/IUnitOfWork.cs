using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileArchive.Core
{
    public interface IUnitOfWork: IDisposable
    {
        //DbSet<TEntity> Set<TEntity>() where TEntity : class;
        //int SaveAllChanges(bool invalidateCacheDependencies = false);
        //Task<int> SaveAllChangesAsync(bool invalidateCacheDependencies = false);
        //void MarkAsChanged<TEntity>(TEntity entity) where TEntity : class;
        //IList<T> GetRows<T>(string sql, params object[] parameters) where T : class;
        //Task<IList<T>> GetRowsAsync<T>(string sql, params object[] parameters) where T : class;
        //Task<int> GetExecuteSqlCommandAsync(string sql, params object[] parameters);
        //Task<int> SaveChangesAsync();
    }
}
