﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanCaFe.Data.EF;

namespace QuanCaFe.Data.Migrations
{
    [DbContext(typeof(QuanCaFeDBContext))]
    partial class QuanCaFeDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
