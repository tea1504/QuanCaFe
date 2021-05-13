using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanCaFe.Data.Entities;

namespace QuanCaFe.Data.Configurations
{
    public class NhanVienConfiguration : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.ToTable("NhanVien");

            builder.HasKey(nv => nv.Id);

            builder.Property(nv => nv.Name)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode();

            builder.HasMany(nv => nv.HoaDons)
                .WithOne(hd => hd.NhanVien);
        }
    }
}
