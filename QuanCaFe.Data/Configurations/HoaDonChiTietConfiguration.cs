using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanCaFe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanCaFe.Data.Configurations
{
    public class HoaDonChiTietConfiguration : IEntityTypeConfiguration<HoaDonChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonChiTiet> builder)
        {
            builder.ToTable("HoaDonChiTiet");

            builder.HasKey(hdct => new { hdct.SoHD, hdct.MSTU });

            builder.Property(hdct => hdct.MSTU)
                .IsRequired();
            builder.Property(hdct => hdct.SoHD)
                .IsRequired();
            builder.Property(hdct => hdct.Soluong)
                .IsRequired();
            builder.Property(hdct => hdct.Giaban)
                .IsRequired();

            builder.HasOne(hdct => hdct.HoaDon)
                .WithMany(h => h.HoaDonChiTiets)
                .HasForeignKey(hdct=>hdct.SoHD);
            builder.HasOne(hdct => hdct.ThucUong)
                .WithMany(tu => tu.HoaDonChiTiets)
                .HasForeignKey(hdct => hdct.MSTU);
        }
    }
}
