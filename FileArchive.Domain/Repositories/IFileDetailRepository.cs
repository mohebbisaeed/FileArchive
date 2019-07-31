using FileArchive.Core;
using FileArchive.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Domain.Repositories
{
    public interface IFileDetailRepository : IGenericRepository<FileDetail, int>
    {
    }
}
