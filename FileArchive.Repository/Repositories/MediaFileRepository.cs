using FileArchive.Domain.Entities;
using FileArchive.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Repository.Repositories
{
   public class MediaFileRepository : GenericRepository<MediaFile, int>, IMediaFileRepository
    {
        public MediaFileRepository(FileArchiveContext ctx) : base(ctx)
        {
        }
    }
}