using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuanCaFe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanCaFe.Data.Configurations
{
    public class BanConfiguration : IEntityTypeConfiguration<Ban>
    {
        public void Configure(EntityTypeBuilder<Ban> builder)
        {
            builder.ToTable("Ban");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Mota)
                .IsUnicode();

            builder.HasMany(b => b.HoaDons)
                .WithOne(hd => hd.Ban);
        }
    }
}
