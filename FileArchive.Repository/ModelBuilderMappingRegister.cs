using FileArchive.Domain.Entities;
using FileArchive.Repository.EntityMappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Repository
{
    public static class ModelBuilderMappingRegister
    {
        public static void RegisterModelCreate(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<File>(new FileMapping());
            modelBuilder.ApplyConfiguration<FileCustomProperty>(new FileCustomPropertyMapping());
            modelBuilder.ApplyConfiguration<FileDetail>(new FileDetailMapping());
            modelBuilder.ApplyConfiguration<FileType>(new FileTypeMapping());
            modelBuilder.ApplyConfiguration<Folder>(new FolderMapping());
            modelBuilder.ApplyConfiguration<ImageFile>(new ImageFileMapping());
            modelBuilder.ApplyConfiguration<MediaFile>(new MediaFileMapping());
            modelBuilder.ApplyConfiguration<Setting>(new SettingMapping());
        }
    }
}
