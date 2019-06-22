using FileArchive.Core;
using FileArchive.Domain.Entities;
using FileArchive.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FileArchive.Repository.Repositories
{
    public class FileTypeRepository : IFileTypeRepository
    {
        protected FileArchiveContext _context;

        public FileTypeRepository(FileArchiveContext context)
        {
            _context = context;
        }

        public IList<FileType> GetAll()
        {
            return _context.Set<FileType>().ToList();
        }

        public async Task<IList<FileType>> GetAllAsync()
        {
            return await _context.Set<FileType>().ToListAsync();
        }
    }
}
