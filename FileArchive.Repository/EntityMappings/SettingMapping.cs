using FileArchive.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Repository.EntityMappings
{
    public class SettingMapping : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).HasMaxLength(50);
            builder.Property(x => x.SettingKey).HasMaxLength(50);
            builder.Property(x => x.Value).HasMaxLength(256);
        }
    }
}
