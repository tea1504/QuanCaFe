using Microsoft.EntityFrameworkCore;
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
        public DbSet<Ban> Bans { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<ThucUong> ThucUongs { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public DbSet<HoaDon> HoaDons { get; set; }
    }
}
