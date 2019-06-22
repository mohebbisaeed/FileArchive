using FileArchive.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Repository.EntityMappings
{
    public class FileCustomPropertyMapping : IEntityTypeConfiguration<FileCustomProperty>
    {
        public void Configure(EntityTypeBuilder<FileCustomProperty> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(256);
            builder.Property(X => X.Sorted);
        }
    }
}
