using FileArchive.Domain.Entities;
using FileArchive.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Repository.Repositories
{
   public  class ImageFileRepository : GenericRepository<ImageFile, int>, IImageFileRepository
    {
        public ImageFileRepository(FileArchiveContext ctx) : base(ctx)
        {
        }
    }
}
