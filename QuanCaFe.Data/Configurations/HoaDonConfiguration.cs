using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanCaFe.Data.Entities;
using QuanCaFe.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanCaFe.Data.Configurations
{
    public class HoaDonConfiguration : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
        {
            builder.ToTable("HoaDon");

            builder.HasKey(hd => hd.Id);

            builder.Property(hd => hd.MSNV)
                .IsRequired();
            builder.Property(hd => hd.Ngaygio)
                .IsRequired();
            builder.Property(hd => hd.Soban)
                .IsRequired();
            builder.Property(hd => hd.Dathanhtoan)
                .HasDefaultValue(ThanhToan.ChuaThanhToan);

            builder.HasMany(hd => hd.HoaDonChiTiets)
                .WithOne(hdct => hdct.HoaDon);
            builder.HasOne(hd => hd.Ban)
                .WithMany(b => b.HoaDons)
                .HasForeignKey(hd => hd.Soban);
            builder.HasOne(hd => hd.NhanVien)
                .WithMany(nv => nv.HoaDons)
                .HasForeignKey(hd => hd.MSNV);
        }
    }
}
