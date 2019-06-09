using FileArchive.Domain.Entities;
using FileArchive.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileArchive.Repository.Repositories
{
    public class FolderRepository : IFolderRepository
    {
        public FolderRepository()
        {
        }

        public void Add(Folder folder)
        {
            throw new NotImplementedException();
        }

        public Task AddAsyn(Folder folder)
        {
            throw new NotImplementedException();
        }

        public void Delete(Folder folder)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsyn(Folder folder)
        {
            throw new NotImplementedException();
        }

        public Folder Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Folder> GetAsyn(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Folder folder)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsyn(Folder folder)
        {
            throw new NotImplementedException();
        }
    }
}
