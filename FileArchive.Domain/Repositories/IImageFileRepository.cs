using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FileArchive.Core;
using FileArchive.Domain.Entities;

namespace FileArchive.Domain.Repositories
{
    public interface IImageFileRepository : IRepository
    {
        ImageFile Add(ImageFile ImageFile);
        Task<ImageFile> AddAsync(ImageFile ImageFile);

        ImageFile Update(ImageFile ImageFile, int id);
        Task<ImageFile> UpdateAsync(ImageFile ImageFile, int id);

        void Delete(ImageFile ImageFile);

        ImageFile Get(int id);
        Task<ImageFile> GetAsync(int id);
    }
}
