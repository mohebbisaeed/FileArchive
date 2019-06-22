using FileArchive.Domain.Entities;
using FileArchive.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Repository.Repositories
{
    public class SettingRepository : GenericRepository<Setting, int>, ISettingRepository
    {
        public SettingRepository(FileArchiveContext ctx) : base(ctx)
        {
        }
    }
}