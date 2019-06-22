using FileArchive.Domain.Entities;
using FileArchive.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Repository.Repositories
{
    public class FileDetailRepository : GenericRepository<FileDetail, int>, IFileDetailRepository
    {
        public FileDetailRepository(FileArchiveContext ctx) : base(ctx)
        {
        }
    }
}
