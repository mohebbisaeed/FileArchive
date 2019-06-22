using FileArchive.Domain.Entities;
using FileArchive.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Repository.Repositories
{
    public class FileCustomPropertyRepository : GenericRepository<FileCustomProperty, int>, IFileCustomPropertyRepository
    {
        public FileCustomPropertyRepository(FileArchiveContext ctx):base(ctx)
        {
        }
    }
}
