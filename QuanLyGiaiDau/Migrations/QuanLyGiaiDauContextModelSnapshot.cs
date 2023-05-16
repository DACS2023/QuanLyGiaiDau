﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyGiaiDau.Models;

namespace QuanLyGiaiDau.Migrations
{
    [DbContext(typeof(QuanLyGiaiDauContext))]
    partial class QuanLyGiaiDauContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuanLyGiaiDau.Models.CT_DoiDau", b =>
                {
                    b.Property<int>("IdCTDoiDau")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdDoiDau")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("IdUser")
                        .HasColumnType("varchar(10)");

                    b.Property<bool>("TrangThaiTV")
                        .HasColumnType("bit");

                    b.HasKey("IdCTDoiDau");

                    b.HasIndex("IdDoiDau");

                    b.HasIndex("IdUser");

                    b.ToTable("CT_DoiDaus");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.CT_TranDau", b =>
                {
                    b.Property<int>("IdCTTranDau")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdDoiDau")
                        .HasColumnType("varchar(10)");

                    b.Property<int>("IdGiaiDau")
                        .HasColumnType("int");

                    b.Property<string>("KetQua")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("SanDau")
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("ThoiGianBatDau")
                        .HasColumnType("datetime");

                    b.Property<int>("TiSo")
                        .HasColumnType("int");

                    b.Property<int>("VongDau")
                        .HasColumnType("int");

                    b.HasKey("IdCTTranDau");

                    b.HasIndex("IdDoiDau");

                    b.HasIndex("IdGiaiDau");

                    b.ToTable("CT_TranDaus");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.DoiDau", b =>
                {
                    b.Property<string>("IdDoiDau")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TenDoiDau")
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("IdDoiDau");

                    b.ToTable("DoiDaus");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.GiaiDau", b =>
                {
                    b.Property<int>("IdGiaiDau")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaDiem")
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("IdLoaiGiaiDau")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("Datetime");

                    b.Property<string>("TenGiaiDau")
                        .HasColumnType("nvarchar(150)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("IdGiaiDau");

                    b.HasIndex("IdLoaiGiaiDau");

                    b.ToTable("GiaiDaus");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.LoaiGiaiDau", b =>
                {
                    b.Property<int>("IdloaiGiaiDau")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IdMonTheThao")
                        .HasColumnType("varchar(10)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("IdloaiGiaiDau");

                    b.HasIndex("IdMonTheThao");

                    b.ToTable("LoaiGiaiDau");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.MonTheThao", b =>
                {
                    b.Property<string>("IdMonTheThao")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("TenMonTheThao")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("IdMonTheThao");

                    b.ToTable("MonTheThaos");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.User", b =>
                {
                    b.Property<string>("IdUser")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("TrangThai")
                        .HasColumnType("bit");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.CT_DoiDau", b =>
                {
                    b.HasOne("QuanLyGiaiDau.Models.DoiDau", "DoiDau")
                        .WithMany()
                        .HasForeignKey("IdDoiDau");

                    b.HasOne("QuanLyGiaiDau.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser");

                    b.Navigation("DoiDau");

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.CT_TranDau", b =>
                {
                    b.HasOne("QuanLyGiaiDau.Models.DoiDau", "DoiDau")
                        .WithMany()
                        .HasForeignKey("IdDoiDau");

                    b.HasOne("QuanLyGiaiDau.Models.GiaiDau", "GiaiDau")
                        .WithMany()
                        .HasForeignKey("IdGiaiDau")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DoiDau");

                    b.Navigation("GiaiDau");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.GiaiDau", b =>
                {
                    b.HasOne("QuanLyGiaiDau.Models.LoaiGiaiDau", "LoaiGiaiDau")
                        .WithMany()
                        .HasForeignKey("IdLoaiGiaiDau");

                    b.Navigation("LoaiGiaiDau");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.LoaiGiaiDau", b =>
                {
                    b.HasOne("QuanLyGiaiDau.Models.MonTheThao", "MonTheThao")
                        .WithMany()
                        .HasForeignKey("IdMonTheThao");

                    b.Navigation("MonTheThao");
                });
#pragma warning restore 612, 618
        }
    }
}
