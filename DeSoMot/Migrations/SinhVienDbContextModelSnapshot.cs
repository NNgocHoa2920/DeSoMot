﻿// <auto-generated />
using System;
using DeSoMot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeSoMot.Migrations
{
    [DbContext(typeof(SinhVienDbContext))]
    partial class SinhVienDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.32")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DeSoMot.Models.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhongBanMaPB")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Tuoi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhongBanMaPB");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("DeSoMot.Models.PhongBan", b =>
                {
                    b.Property<string>("MaPB")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPB");

                    b.ToTable("PhongBans");
                });

            modelBuilder.Entity("DeSoMot.Models.NhanVien", b =>
                {
                    b.HasOne("DeSoMot.Models.PhongBan", "PhongBan")
                        .WithMany("NhanViens")
                        .HasForeignKey("PhongBanMaPB");

                    b.Navigation("PhongBan");
                });

            modelBuilder.Entity("DeSoMot.Models.PhongBan", b =>
                {
                    b.Navigation("NhanViens");
                });
#pragma warning restore 612, 618
        }
    }
}
