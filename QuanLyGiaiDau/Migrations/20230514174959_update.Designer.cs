﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyGiaiDau.Models;

namespace QuanLyGiaiDau.Migrations
{
    [DbContext(typeof(QuanLyGiaiDauContext))]
    [Migration("20230514174959_update")]
    partial class update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuanLyGiaiDau.Models.CT_DoiDau", b =>
                {
                    b.Property<string>("DoiDauIdTranDau")
                        .HasColumnType("varchar(10)");

                    b.Property<bool>("TrangThaiTV")
                        .HasColumnType("bit");

                    b.Property<string>("UserIdUser")
                        .HasColumnType("varchar(10)");

                    b.HasIndex("DoiDauIdTranDau");

                    b.HasIndex("UserIdUser");

                    b.ToTable("CT_DoiDaus");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.CT_TranDau", b =>
                {
                    b.Property<string>("DoiDauIdTranDau")
                        .HasColumnType("varchar(10)");

                    b.Property<int?>("GiaiDauIdGiaiDau")
                        .HasColumnType("int");

                    b.Property<string>("KetQua")
                        .HasColumnType("varchar");

                    b.Property<string>("SanDau")
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("ThoiGianBatDau")
                        .HasColumnType("DateTime");

                    b.Property<int>("TiSo")
                        .HasColumnType("int");

                    b.Property<int>("VongDau")
                        .HasColumnType("int");

                    b.HasIndex("DoiDauIdTranDau");

                    b.HasIndex("GiaiDauIdGiaiDau");

                    b.ToTable("CT_TranDaus");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.DoiDau", b =>
                {
                    b.Property<string>("IdTranDau")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("TenDoiDau")
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("IdTranDau");

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

                    b.Property<int?>("LoaiGiaiDauIdloaiGiaiDau")
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

                    b.HasIndex("LoaiGiaiDauIdloaiGiaiDau");

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
                        .HasForeignKey("DoiDauIdTranDau");

                    b.HasOne("QuanLyGiaiDau.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserIdUser");

                    b.Navigation("DoiDau");

                    b.Navigation("User");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.CT_TranDau", b =>
                {
                    b.HasOne("QuanLyGiaiDau.Models.DoiDau", "DoiDau")
                        .WithMany()
                        .HasForeignKey("DoiDauIdTranDau");

                    b.HasOne("QuanLyGiaiDau.Models.GiaiDau", "GiaiDau")
                        .WithMany()
                        .HasForeignKey("GiaiDauIdGiaiDau");

                    b.Navigation("DoiDau");

                    b.Navigation("GiaiDau");
                });

            modelBuilder.Entity("QuanLyGiaiDau.Models.GiaiDau", b =>
                {
                    b.HasOne("QuanLyGiaiDau.Models.LoaiGiaiDau", "LoaiGiaiDau")
                        .WithMany()
                        .HasForeignKey("LoaiGiaiDauIdloaiGiaiDau");

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
