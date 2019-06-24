using FileArchive.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileArchive.Repository.EntityMappings
{
    public class ImageFileMapping : IEntityTypeConfiguration<ImageFile>
    {
        public void Configure(EntityTypeBuilder<ImageFile> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Equip_Make).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.Y_ResolutionY).HasMaxLength(20).HasColumnType("varchar");
            builder.Property(x => x.X_Resolution).HasMaxLength(20).HasColumnType("varchar");
            builder.Property(x => x.User_Comment).HasMaxLength(50);
            builder.Property(x => x.DTDigitized).HasMaxLength(20).HasColumnType("varchar");
            builder.Property(x => x.Shutter_Speed).HasMaxLength(20).HasColumnType("varchar");
            builder.Property(x => x.Equip_Model).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.F_Number).HasMaxLength(20).HasColumnType("varchar");
            builder.Property(x => x.Experture_Time).HasMaxLength(20).HasColumnType("varchar");
            builder.Property(x => x.Sensing_Method).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.MapUrl).HasMaxLength(100).HasColumnType("varchar");
            builder.Property(x => x.LatitudeGeoCode).HasColumnType("Decimal(15,10)");
            builder.Property(x => x.LongitudeGeoCode).HasColumnType("Decimal(15,10)");

            builder.Property(x => x.Latitude).HasColumnType("Decimal(9,6)");
            builder.Property(x => x.Longitude).HasColumnType("Decimal(9,6)");

        }
    }
}
