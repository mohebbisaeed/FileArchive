using FileArchive.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Repository.EntityMappings
{
    public class FileDetailMapping : IEntityTypeConfiguration<FileDetail>
    {
        public void Configure(EntityTypeBuilder<FileDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CreateDate).HasDefaultValueSql("getdate()");
            builder.Property(x => x.CustomProperty1).HasMaxLength(256);
            builder.Property(x => x.CustomProperty2).HasMaxLength(256);
            builder.Property(x => x.CustomProperty3).HasMaxLength(256);
            builder.Property(x => x.CustomProperty4).HasMaxLength(256);
            builder.Property(x => x.CustomProperty5).HasMaxLength(256);
            builder.Property(x => x.CustomProperty6).HasMaxLength(256);
            builder.Property(x => x.CustomProperty7).HasMaxLength(256);
            builder.Property(x => x.CustomProperty8).HasMaxLength(256);
            builder.Property(x => x.CustomProperty9).HasMaxLength(256);
            builder.Property(x => x.CustomProperty10).HasMaxLength(256);
            builder.Property(x => x.ExtentionFile).HasMaxLength(10);
            builder.Property(x => x.Keyword).HasMaxLength(256);
            builder.Property(x => x.OrginalFileName).HasMaxLength(256);
            builder.Property(x => x.Rating).HasDefaultValueSql("0");
            builder.Property(x => x.RatingCount).HasDefaultValue("0");
            builder.Property(x => x.Title).HasMaxLength(256);
        }
    }
}
