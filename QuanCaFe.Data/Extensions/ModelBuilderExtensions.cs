using Microsoft.EntityFrameworkCore;
using QuanCaFe.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanCaFe.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ban>().HasData(
                new Ban { Id = 1, Mota = "Mô tả bàn 1" },
                new Ban { Id = 2, Mota = "Mô tả bàn 2" },
                new Ban { Id = 3, Mota = "Mô tả bàn 3" },
                new Ban { Id = 4, Mota = "Mô tả bàn 4" },
                new Ban { Id = 5, Mota = "Mô tả bàn 5" }
                );
            modelBuilder.Entity<NhanVien>().HasData(
                new NhanVien { Id = 1, Name = "Trần Văn Hòa" },
                new NhanVien { Id = 2, Name = "Trần Văn An" },
                new NhanVien { Id = 3, Name = "Trần Văn Khang" },
                new NhanVien { Id = 4, Name = "Trần Văn Thịnh" },
                new NhanVien { Id = 5, Name = "Trần Văn Vượng" }
                );
            modelBuilder.Entity<ThucUong>().HasData(
                new ThucUong { Id = 1, TenTU = "Trà đường", GiaTU = 2000.0f },
                new ThucUong { Id = 2, TenTU = "Trà đá", GiaTU = 1000.0f },
                new ThucUong { Id = 3, TenTU = "CaFe đen", GiaTU = 5000.0f },
                new ThucUong { Id = 4, TenTU = "CaFe sữa", GiaTU = 7000.0f },
                new ThucUong { Id = 5, TenTU = "Nước suối", GiaTU = 3500.0f }
                );
            modelBuilder.Entity<HoaDon>().HasData(
                new HoaDon { Id = 1, Soban = 1, MSNV = 1, Dathanhtoan = Enum.ThanhToan.DaThanhToan, Ngaygio = new DateTime(2021, 5, 13, 17, 2, 3) },
                new HoaDon { Id = 2, Soban = 2, MSNV = 2, Dathanhtoan = Enum.ThanhToan.DaThanhToan, Ngaygio = new DateTime(2021, 5, 13, 18, 2, 3) },
                new HoaDon { Id = 3, Soban = 3, MSNV = 1, Dathanhtoan = Enum.ThanhToan.DaThanhToan, Ngaygio = new DateTime(2021, 5, 14, 18, 2, 3) },
                new HoaDon { Id = 4, Soban = 4, MSNV = 3, Dathanhtoan = Enum.ThanhToan.DaThanhToan, Ngaygio = new DateTime(2021, 5, 14, 10, 2, 3) },
                new HoaDon { Id = 5, Soban = 5, MSNV = 2, Dathanhtoan = Enum.ThanhToan.DaThanhToan, Ngaygio = new DateTime(2021, 5, 15, 18, 2, 3) },
                new HoaDon { Id = 6, Soban = 4, MSNV = 4, Dathanhtoan = Enum.ThanhToan.DaThanhToan, Ngaygio = new DateTime(2021, 5, 16, 15, 2, 3) },
                new HoaDon { Id = 7, Soban = 3, MSNV = 5, Dathanhtoan = Enum.ThanhToan.DaThanhToan, Ngaygio = new DateTime(2021, 5, 16, 18, 2, 3) }
                );
            modelBuilder.Entity<HoaDonChiTiet>().HasData(
                new HoaDonChiTiet() { SoHD = 1, MSTU = 1, Giaban = 2000.0f, Soluong = 1 },
                new HoaDonChiTiet() { SoHD = 2, MSTU = 1, Giaban = 2000.0f, Soluong = 1 },
                new HoaDonChiTiet() { SoHD = 3, MSTU = 1, Giaban = 2000.0f, Soluong = 1 },
                new HoaDonChiTiet() { SoHD = 4, MSTU = 1, Giaban = 2000.0f, Soluong = 1 },
                new HoaDonChiTiet() { SoHD = 5, MSTU = 1, Giaban = 2000.0f, Soluong = 1 },
                new HoaDonChiTiet() { SoHD = 6, MSTU = 1, Giaban = 2000.0f, Soluong = 1 },
                new HoaDonChiTiet() { SoHD = 7, MSTU = 1, Giaban = 2000.0f, Soluong = 1 }
                );
        }
    }
}
