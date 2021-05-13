using Microsoft.EntityFrameworkCore;
using QuanCaFe.Data.Configurations;
using QuanCaFe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanCaFe.Data.EF
{
    public class QuanCaFeDBContext : DbContext
    {
        public QuanCaFeDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BanConfiguration());
            modelBuilder.ApplyConfiguration(new NhanVienConfiguration());
            modelBuilder.ApplyConfiguration(new ThucUongConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonChiTietConfiguration());
            modelBuilder.ApplyConfiguration(new HoaDonConfiguration());
            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Ban> Bans { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ThucUong> ThucUongs { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
    }
}
