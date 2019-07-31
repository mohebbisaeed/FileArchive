using FileArchive.Core;
using FileArchive.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileArchive.Domain.Repositories
{
    public interface IFolderRepository : IGenericRepository<Folder, int>
    {
        //Folder Add(Folder folder);
        //Task<Folder> AddAsync(Folder folder);

        //Folder Update(Folder folder, int id);
        //Task<Folder> UpdateAsync(Folder folder, int id);

        //void Delete(Folder folder);

        //Folder Get(int id);
        //Task<Folder> GetAsync(int id);
    }
}
