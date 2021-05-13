using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuanCaFe.Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ban",
                columns: new[] { "Id", "Mota" },
                values: new object[,]
                {
                    { 1, "Mô tả bàn 1" },
                    { 2, "Mô tả bàn 2" },
                    { 3, "Mô tả bàn 3" },
                    { 4, "Mô tả bàn 4" },
                    { 5, "Mô tả bàn 5" }
                });

            migrationBuilder.InsertData(
                table: "NhanVien",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Trần Văn Hòa" },
                    { 2, "Trần Văn An" },
                    { 3, "Trần Văn Khang" },
                    { 4, "Trần Văn Thịnh" },
                    { 5, "Trần Văn Vượng" }
                });

            migrationBuilder.InsertData(
                table: "ThucUong",
                columns: new[] { "Id", "GiaTU", "TenTU" },
                values: new object[,]
                {
                    { 1, 2000f, "Trà đường" },
                    { 2, 1000f, "Trà đá" },
                    { 3, 5000f, "CaFe đen" },
                    { 4, 7000f, "CaFe sữa" },
                    { 5, 3500f, "Nước suối" }
                });

            migrationBuilder.InsertData(
                table: "HoaDon",
                columns: new[] { "Id", "Dathanhtoan", "MSNV", "Ngaygio", "Soban" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2021, 5, 13, 17, 2, 3, 0, DateTimeKind.Unspecified), 1 },
                    { 3, 1, 1, new DateTime(2021, 5, 14, 18, 2, 3, 0, DateTimeKind.Unspecified), 3 },
                    { 2, 1, 2, new DateTime(2021, 5, 13, 18, 2, 3, 0, DateTimeKind.Unspecified), 2 },
                    { 5, 1, 2, new DateTime(2021, 5, 15, 18, 2, 3, 0, DateTimeKind.Unspecified), 5 },
                    { 4, 1, 3, new DateTime(2021, 5, 14, 10, 2, 3, 0, DateTimeKind.Unspecified), 4 },
                    { 6, 1, 4, new DateTime(2021, 5, 16, 15, 2, 3, 0, DateTimeKind.Unspecified), 4 },
                    { 7, 1, 5, new DateTime(2021, 5, 16, 18, 2, 3, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "HoaDonChiTiet",
                columns: new[] { "MSTU", "SoHD", "Giaban", "Soluong" },
                values: new object[,]
                {
                    { 1, 1, 2000f, 1 },
                    { 1, 3, 2000f, 1 },
                    { 1, 2, 2000f, 1 },
                    { 1, 5, 2000f, 1 },
                    { 1, 4, 2000f, 1 },
                    { 1, 6, 2000f, 1 },
                    { 1, 7, 2000f, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumns: new[] { "MSTU", "SoHD" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumns: new[] { "MSTU", "SoHD" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumns: new[] { "MSTU", "SoHD" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumns: new[] { "MSTU", "SoHD" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumns: new[] { "MSTU", "SoHD" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumns: new[] { "MSTU", "SoHD" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "HoaDonChiTiet",
                keyColumns: new[] { "MSTU", "SoHD" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ThucUong",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ThucUong",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ThucUong",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ThucUong",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HoaDon",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ThucUong",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ban",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ban",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ban",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ban",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ban",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NhanVien",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NhanVien",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NhanVien",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NhanVien",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NhanVien",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
