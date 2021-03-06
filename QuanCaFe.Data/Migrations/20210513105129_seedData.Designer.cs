// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanCaFe.Data.EF;

namespace QuanCaFe.Data.Migrations
{
    [DbContext(typeof(QuanCaFeDBContext))]
    [Migration("20210513105129_seedData")]
    partial class seedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuanCaFe.Data.Entities.Ban", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Mota")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ban");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Mota = "Mô tả bàn 1"
                        },
                        new
                        {
                            Id = 2,
                            Mota = "Mô tả bàn 2"
                        },
                        new
                        {
                            Id = 3,
                            Mota = "Mô tả bàn 3"
                        },
                        new
                        {
                            Id = 4,
                            Mota = "Mô tả bàn 4"
                        },
                        new
                        {
                            Id = 5,
                            Mota = "Mô tả bàn 5"
                        });
                });

            modelBuilder.Entity("QuanCaFe.Data.Entities.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Dathanhtoan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("MSNV")
                        .HasColumnType("int");

                    b.Property<DateTime>("Ngaygio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Soban")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MSNV");

                    b.HasIndex("Soban");

                    b.ToTable("HoaDon");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Dathanhtoan = 1,
                            MSNV = 1,
                            Ngaygio = new DateTime(2021, 5, 13, 17, 2, 3, 0, DateTimeKind.Unspecified),
                            Soban = 1
                        },
                        new
                        {
                            Id = 2,
                            Dathanhtoan = 1,
                            MSNV = 2,
                            Ngaygio = new DateTime(2021, 5, 13, 18, 2, 3, 0, DateTimeKind.Unspecified),
                            Soban = 2
                        },
                        new
                        {
                            Id = 3,
                            Dathanhtoan = 1,
                            MSNV = 1,
                            Ngaygio = new DateTime(2021, 5, 14, 18, 2, 3, 0, DateTimeKind.Unspecified),
                            Soban = 3
                        },
                        new
                        {
                            Id = 4,
                            Dathanhtoan = 1,
                            MSNV = 3,
                            Ngaygio = new DateTime(2021, 5, 14, 10, 2, 3, 0, DateTimeKind.Unspecified),
                            Soban = 4
                        },
                        new
                        {
                            Id = 5,
                            Dathanhtoan = 1,
                            MSNV = 2,
                            Ngaygio = new DateTime(2021, 5, 15, 18, 2, 3, 0, DateTimeKind.Unspecified),
                            Soban = 5
                        },
                        new
                        {
                            Id = 6,
                            Dathanhtoan = 1,
                            MSNV = 4,
                            Ngaygio = new DateTime(2021, 5, 16, 15, 2, 3, 0, DateTimeKind.Unspecified),
                            Soban = 4
                        },
                        new
                        {
                            Id = 7,
                            Dathanhtoan = 1,
                            MSNV = 5,
                            Ngaygio = new DateTime(2021, 5, 16, 18, 2, 3, 0, DateTimeKind.Unspecified),
                            Soban = 3
                        });
                });

            modelBuilder.Entity("QuanCaFe.Data.Entities.HoaDonChiTiet", b =>
                {
                    b.Property<int>("SoHD")
                        .HasColumnType("int");

                    b.Property<int>("MSTU")
                        .HasColumnType("int");

                    b.Property<float>("Giaban")
                        .HasColumnType("real");

                    b.Property<int>("Soluong")
                        .HasColumnType("int");

                    b.HasKey("SoHD", "MSTU");

                    b.HasIndex("MSTU");

                    b.ToTable("HoaDonChiTiet");

                    b.HasData(
                        new
                        {
                            SoHD = 1,
                            MSTU = 1,
                            Giaban = 2000f,
                            Soluong = 1
                        },
                        new
                        {
                            SoHD = 2,
                            MSTU = 1,
                            Giaban = 2000f,
                            Soluong = 1
                        },
                        new
                        {
                            SoHD = 3,
                            MSTU = 1,
                            Giaban = 2000f,
                            Soluong = 1
                        },
                        new
                        {
                            SoHD = 4,
                            MSTU = 1,
                            Giaban = 2000f,
                            Soluong = 1
                        },
                        new
                        {
                            SoHD = 5,
                            MSTU = 1,
                            Giaban = 2000f,
                            Soluong = 1
                        },
                        new
                        {
                            SoHD = 6,
                            MSTU = 1,
                            Giaban = 2000f,
                            Soluong = 1
                        },
                        new
                        {
                            SoHD = 7,
                            MSTU = 1,
                            Giaban = 2000f,
                            Soluong = 1
                        });
                });

            modelBuilder.Entity("QuanCaFe.Data.Entities.NhanVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("NhanVien");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Trần Văn Hòa"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Trần Văn An"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Trần Văn Khang"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Trần Văn Thịnh"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Trần Văn Vượng"
                        });
                });

            modelBuilder.Entity("QuanCaFe.Data.Entities.ThucUong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("GiaTU")
                        .HasColumnType("real");

                    b.Property<string>("TenTU")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("ThucUong");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GiaTU = 2000f,
                            TenTU = "Trà đường"
                        },
                        new
                        {
                            Id = 2,
                            GiaTU = 1000f,
                            TenTU = "Trà đá"
                        },
                        new
                        {
                            Id = 3,
                            GiaTU = 5000f,
                            TenTU = "CaFe đen"
                        },
                        new
                        {
                            Id = 4,
                            GiaTU = 7000f,
                            TenTU = "CaFe sữa"
                        },
                        new
                        {
                            Id = 5,
                            GiaTU = 3500f,
                            TenTU = "Nước suối"
                        });
                });

            modelBuilder.Entity("QuanCaFe.Data.Entities.HoaDon", b =>
                {
                    b.HasOne("QuanCaFe.Data.Entities.NhanVien", "NhanVien")
                        .WithMany("HoaDons")
                        .HasForeignKey("MSNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanCaFe.Data.Entities.Ban", "Ban")
                        .WithMany("HoaDons")
                        .HasForeignKey("Soban")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ban");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("QuanCaFe.Data.Entities.HoaDonChiTiet", b =>
                {
                    b.HasOne("QuanCaFe.Data.Entities.ThucUong", "ThucUong")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("MSTU")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QuanCaFe.Data.Entities.HoaDon", "HoaDon")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("SoHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("ThucUong");
                });

            modelBuilder.Entity("QuanCaFe.Data.Entities.Ban", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("QuanCaFe.Data.Entities.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("QuanCaFe.Data.Entities.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("QuanCaFe.Data.Entities.ThucUong", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });
#pragma warning restore 612, 618
        }
    }
}
