using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FileArchive.Core;
using FileArchive.Domain.Entities;

namespace FileArchive.Domain.Repositories
{
    public interface IFileTypeRepository : IRepository
    {
        Task<IList<FileType>> GetAllAsync();
        IList<FileType> GetAll();
    }
}
