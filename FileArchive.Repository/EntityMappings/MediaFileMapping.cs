using FileArchive.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Repository.EntityMappings
{
    public class MediaFileMapping : IEntityTypeConfiguration<MediaFile>
    {
        public void Configure(EntityTypeBuilder<MediaFile> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(256);
            builder.Property(x => x.EndTime).HasColumnType("time(7)");
            builder.Property(x => x.StartTime).HasColumnType("time(7)");
        }
    }
}
