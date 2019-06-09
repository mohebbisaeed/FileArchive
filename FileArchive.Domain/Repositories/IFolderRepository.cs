using FileArchive.Core;
using FileArchive.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileArchive.Domain.Repositories
{
    public interface IFolderRepository : IRepository
    {
        void Add(Folder folder);
        Task AddAsyn(Folder folder);

        void Update(Folder folder);
        Task UpdateAsyn(Folder folder);

        void Delete(Folder folder);
        Task DeleteAsyn(Folder folder);

        Folder Get(int id);
        Task<Folder> GetAsyn(int id);
    }
}
