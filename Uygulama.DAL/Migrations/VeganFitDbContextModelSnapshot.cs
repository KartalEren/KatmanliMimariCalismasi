﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Uygulama.DAL.Concrete.Context;

#nullable disable

namespace Uygulama.DAL.Migrations
{
    [DbContext(typeof(VeganFitDbContext))]
    partial class VeganFitDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Uygulama.Entities.Data", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Calori")
                        .HasColumnType("float");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("date");

                    b.Property<string>("Meal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserEmail")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("Datas");
                });

            modelBuilder.Entity("Uygulama.Entities.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Uygulama.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<double>("Calori")
                        .HasColumnType("float");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Picture")
                        .HasColumnType("Image");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Serving")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductName")
                        .IsUnique();

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calori = 128.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Kepekli Ekmek",
                            Serving = "46",
                            State = "Created"
                        },
                        new
                        {
                            Id = 2,
                            Calori = 116.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Elma",
                            Serving = "223",
                            State = "Created"
                        },
                        new
                        {
                            Id = 3,
                            Calori = 193.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Ceviz",
                            Serving = "30",
                            State = "Created"
                        },
                        new
                        {
                            Id = 4,
                            Calori = 105.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Muz",
                            Serving = "223",
                            State = "Created"
                        },
                        new
                        {
                            Id = 5,
                            Calori = 1.5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Maydonoz",
                            Serving = "0.5",
                            State = "Created"
                        },
                        new
                        {
                            Id = 6,
                            Calori = 16.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Siyah Zeytin",
                            Serving = "15.2",
                            State = "Created"
                        },
                        new
                        {
                            Id = 7,
                            Calori = 32.799999999999997,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Yeşil Biber",
                            Serving = "164",
                            State = "Created"
                        },
                        new
                        {
                            Id = 8,
                            Calori = 16.800000000000001,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Kayısı",
                            Serving = "35",
                            State = "Created"
                        },
                        new
                        {
                            Id = 9,
                            Calori = 75.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Mercimek Çorbası",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 10,
                            Calori = 174.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Badem",
                            Serving = "30",
                            State = "Created"
                        },
                        new
                        {
                            Id = 11,
                            Calori = 39.299999999999997,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Badem Sütü",
                            Serving = "262",
                            State = "Created"
                        },
                        new
                        {
                            Id = 12,
                            Calori = 8.5999999999999996,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Çilek",
                            Serving = "27",
                            State = "Created"
                        },
                        new
                        {
                            Id = 13,
                            Calori = 86.5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Portakal",
                            Serving = "184",
                            State = "Created"
                        },
                        new
                        {
                            Id = 14,
                            Calori = 22.100000000000001,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Domates",
                            Serving = "123",
                            State = "Created"
                        },
                        new
                        {
                            Id = 15,
                            Calori = 96.400000000000006,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Müsli",
                            Serving = "28.2",
                            State = "Created"
                        },
                        new
                        {
                            Id = 16,
                            Calori = 234.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Nar",
                            Serving = "282",
                            State = "Created"
                        },
                        new
                        {
                            Id = 17,
                            Calori = 116.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Kepekli Grissini",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 18,
                            Calori = 30.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Vegan Sade Peynir",
                            Serving = "87.3",
                            State = "Created"
                        },
                        new
                        {
                            Id = 20,
                            Calori = 116.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Bulgur Pilavı",
                            Serving = "89.2",
                            State = "Created"
                        },
                        new
                        {
                            Id = 21,
                            Calori = 119.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Zeytin Yağı",
                            Serving = "13.5",
                            State = "Created"
                        },
                        new
                        {
                            Id = 22,
                            Calori = 116.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Konserve Yeşil Bezelye",
                            Serving = "163",
                            State = "Created"
                        },
                        new
                        {
                            Id = 23,
                            Calori = 85.799999999999997,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Karpuz",
                            Serving = "286",
                            State = "Created"
                        },
                        new
                        {
                            Id = 24,
                            Calori = 15.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Mandalina",
                            Serving = "23.8",
                            State = "Created"
                        },
                        new
                        {
                            Id = 25,
                            Calori = 74.799999999999997,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Ispanaklı Börek",
                            Serving = "28.4",
                            State = "Created"
                        },
                        new
                        {
                            Id = 26,
                            Calori = 4.2000000000000002,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Turşu",
                            Serving = "35",
                            State = "Created"
                        },
                        new
                        {
                            Id = 27,
                            Calori = 79.400000000000006,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Domates Çorbası",
                            Serving = "248",
                            State = "Created"
                        },
                        new
                        {
                            Id = 28,
                            Calori = 358.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Patates Salatası",
                            Serving = "250",
                            State = "Created"
                        },
                        new
                        {
                            Id = 29,
                            Calori = 166.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Yulaf Ezmesi",
                            Serving = "234",
                            State = "Created"
                        },
                        new
                        {
                            Id = 30,
                            Calori = 79.900000000000006,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Karışık Sebze",
                            Serving = "163",
                            State = "Created"
                        },
                        new
                        {
                            Id = 31,
                            Calori = 41.899999999999999,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Kuru Üzüm",
                            Serving = "14",
                            State = "Created"
                        },
                        new
                        {
                            Id = 32,
                            Calori = 68.900000000000006,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Çok Tahıllı Ekmek",
                            Serving = "26",
                            State = "Created"
                        },
                        new
                        {
                            Id = 33,
                            Calori = 125.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Sebzeli Makarna",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 34,
                            Calori = 38.700000000000003,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Portakal Suyu",
                            Serving = "86",
                            State = "Created"
                        },
                        new
                        {
                            Id = 35,
                            Calori = 2.5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Yeşil Çay",
                            Serving = "245",
                            State = "Created"
                        },
                        new
                        {
                            Id = 36,
                            Calori = 16.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Zeytinyağlı Taze Fasulye",
                            Serving = "20.3",
                            State = "Created"
                        },
                        new
                        {
                            Id = 37,
                            Calori = 52.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Ezogelin Çorbası",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 38,
                            Calori = 86.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Mücver",
                            Serving = "74.8",
                            State = "Created"
                        },
                        new
                        {
                            Id = 39,
                            Calori = 101.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Armut",
                            Serving = "178",
                            State = "Created"
                        },
                        new
                        {
                            Id = 40,
                            Calori = 106.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Burger",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 41,
                            Calori = 26.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Ratatouille",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 42,
                            Calori = 129.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Ispanaklı Pizza",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 43,
                            Calori = 110.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Mantarlı Kinoa Risotto",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 44,
                            Calori = 45.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Fırında Domatesli Kabak Dilimleri",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 45,
                            Calori = 164.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Muzlu Vegan Fransız Tostu",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 46,
                            Calori = 80.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Avokado Soslu Patetes",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 47,
                            Calori = 92.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Mantar ve Pırasalı Tofu",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 48,
                            Calori = 47.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Patates ve Roka Çorbası",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 49,
                            Calori = 140.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Şeftali Püreli Tatlı Kuskus",
                            Serving = "100",
                            State = "Created"
                        },
                        new
                        {
                            Id = 50,
                            Calori = 68.0,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProductName = "Yaban Mersinli Kinoa Lapası",
                            Serving = "100",
                            State = "Created"
                        });
                });

            modelBuilder.Entity("Uygulama.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(1992, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 7, 30, 3, 43, 26, 868, DateTimeKind.Local).AddTicks(8367),
                            Email = "admin@gmail.com",
                            Firstname = "Eren",
                            Lastname = "Kartal",
                            Password = "Ek1.",
                            Role = "Admin",
                            State = "Created"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(1999, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedDate = new DateTime(2023, 7, 30, 3, 43, 26, 868, DateTimeKind.Local).AddTicks(8474),
                            Email = "pelin@gmail.com",
                            Firstname = "Pelin",
                            Lastname = "Uru",
                            Password = "1234",
                            Role = "StandartUser",
                            State = "Created"
                        });
                });

            modelBuilder.Entity("Uygulama.Entities.Weight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RecordDate")
                        .HasColumnType("date");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("UserWeight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Weights");
                });

            modelBuilder.Entity("Uygulama.Entities.Data", b =>
                {
                    b.HasOne("Uygulama.Entities.Product", "Product")
                        .WithMany("Datas")
                        .HasForeignKey("ProductId");

                    b.HasOne("Uygulama.Entities.User", "User")
                        .WithMany("Datas")
                        .HasForeignKey("UserId");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Uygulama.Entities.Feedback", b =>
                {
                    b.HasOne("Uygulama.Entities.User", "User")
                        .WithMany("Feedbacks")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Uygulama.Entities.Weight", b =>
                {
                    b.HasOne("Uygulama.Entities.User", "User")
                        .WithMany("Weights")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Uygulama.Entities.Product", b =>
                {
                    b.Navigation("Datas");
                });

            modelBuilder.Entity("Uygulama.Entities.User", b =>
                {
                    b.Navigation("Datas");

                    b.Navigation("Feedbacks");

                    b.Navigation("Weights");
                });
#pragma warning restore 612, 618
        }
    }
}
