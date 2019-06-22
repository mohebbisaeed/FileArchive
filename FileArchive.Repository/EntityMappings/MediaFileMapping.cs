using FileArchive.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Repository.EntityMappings
{
    class MediaFileMapping : IEntityTypeConfiguration<MediaFile>
    {
        public void Configure(EntityTypeBuilder<MediaFile> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FileExtention).HasMaxLength(10);
        }
    }
}
