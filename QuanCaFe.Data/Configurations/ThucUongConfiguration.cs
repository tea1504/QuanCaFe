using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanCaFe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanCaFe.Data.Configurations
{
    public class ThucUongConfiguration : IEntityTypeConfiguration<ThucUong>
    {
        public void Configure(EntityTypeBuilder<ThucUong> builder)
        {
            builder.ToTable("ThucUong");

            builder.HasKey(tu => tu.Id);

            builder.Property(tu => tu.GiaTU)
                .IsRequired();
            builder.Property(tu => tu.TenTU)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode();

            builder.HasMany(tu => tu.HoaDonChiTiets)
                .WithOne(hdct => hdct.ThucUong);
        }
    }
}
