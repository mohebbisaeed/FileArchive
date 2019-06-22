using FileArchive.Domain.Entities;
using FileArchive.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FileArchive.Repository.Repositories
{
    public class FileRepository : GenericRepository<Domain.Entities.File, Guid>, IFileRepository
    {
        public FileRepository(FileArchiveContext ctx) : base(ctx)
        {
        }
    }
}
