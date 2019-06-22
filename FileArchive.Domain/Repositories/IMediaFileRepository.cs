using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FileArchive.Core;
using FileArchive.Domain.Entities;

namespace FileArchive.Domain.Repositories
{
    public interface IMediaFileRepository : IRepository
    {
        MediaFile Add(MediaFile MediaFile);
        Task<MediaFile> AddAsync(MediaFile MediaFile);

        MediaFile Update(MediaFile MediaFile, int id);
        Task<MediaFile> UpdateAsync(MediaFile MediaFile, int id);

        void Delete(MediaFile MediaFile);

        MediaFile Get(int id);
        Task<MediaFile> GetAsync(int id);
    }
}
