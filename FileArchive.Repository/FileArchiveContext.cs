using Microsoft.EntityFrameworkCore;
using System;
using EFSecondLevelCache.Core;

namespace FileArchive.Repository
{
    public class FileArchiveContext : DbContext
    {
        public FileArchiveContext(DbContextOptions<FileArchiveContext> options) : base(options)
        { }

        //public override int SaveChanges()
        //{
        //    var changedEntityNames = this.GetChangedEntityNames();

        //    this.ChangeTracker.AutoDetectChangesEnabled = false; // for performance reasons, to avoid calling DetectChanges() again.
        //    var result = base.SaveChanges();
        //    this.ChangeTracker.AutoDetectChangesEnabled = true;

        //    this.GetService<IEFCacheServiceProvider>().InvalidateCacheDependencies(changedEntityNames);

        //    return result;
        //}

    }
}
