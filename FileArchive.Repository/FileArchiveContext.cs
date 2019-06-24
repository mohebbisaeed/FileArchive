using Microsoft.EntityFrameworkCore;
using System;
using EFSecondLevelCache.Core;
using FileArchive.Domain.Entities;
using System.Configuration;

namespace FileArchive.Repository
{
    public class FileArchiveContext : DbContext
    {
        public FileArchiveContext(DbContextOptions<FileArchiveContext> options) : base(options)
        {
        }

        #region Dbsets
        public DbSet<File> Files { get; set; }
        public DbSet<FileCustomProperty> FileCustomProperties { get; set; }
        public DbSet<FileDetail> FileDetails { get; set; }
        public DbSet<FileType> FileTypes { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<ImageFile> ImageFiles { get; set; }
        public DbSet<MediaFile> MediaFiles { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ModelBuilderMappingRegister.RegisterModelCreate(modelBuilder);

            modelBuilder.Entity<FileType>().HasData(
                                new FileType { Id = 1, Title = "Image" },
                                new FileType { Id = 2, Title = "Media" },
                                new FileType { Id = 3, Title = "Other" }
                                );
            base.OnModelCreating(modelBuilder);
        }

    }
}
