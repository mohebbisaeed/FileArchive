using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FileArchive.Core;
using FileArchive.Domain.Entities;

namespace FileArchive.Domain.Repositories
{
    public interface IFileRepository : IGenericRepository<File, Guid>
    {
        //File Add(File folder);
        //Task<File> AddAsync(File folder);

        //File Update(File folder, Guid id);
        //Task<File> UpdateAsync(File folder, Guid id);

        //void Delete(File folder);

        //File Get(Guid id);
        //Task<File> GetAsync(Guid id);
    }
}
