﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShipmentСoterie.Tables;

#nullable disable

namespace ShipmentСoterie.Migrations
{
    [DbContext(typeof(CoterieContext))]
    [Migration("20240512201919_initDatabaseFirst")]
    partial class initDatabaseFirst
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShipmentСoterie.Tables.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("payMethodid")
                        .HasColumnType("int");

                    b.Property<int>("statusid")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("payMethodid");

                    b.HasIndex("statusid");

                    b.HasIndex("userId");

                    b.ToTable("order");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.OrderList", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("orderId")
                        .HasColumnType("int");

                    b.Property<int>("productid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("orderId");

                    b.HasIndex("productid");

                    b.ToTable("orderList");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.OrderStatus", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("orderStatus");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.PayMethod", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("payMethod");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("shopId")
                        .HasColumnType("int");

                    b.Property<int>("typeid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("shopId");

                    b.HasIndex("typeid");

                    b.ToTable("product");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.ProductType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("productType");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.Profile", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("cardNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("personalDiscount")
                        .HasColumnType("real");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("secondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("thirdName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("profile");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("role");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.Shop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("shop");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("profileid")
                        .HasColumnType("int");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("profileid");

                    b.HasIndex("roleId");

                    b.ToTable("user");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.Order", b =>
                {
                    b.HasOne("ShipmentСoterie.Tables.PayMethod", "payMethod")
                        .WithMany()
                        .HasForeignKey("payMethodid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShipmentСoterie.Tables.OrderStatus", "status")
                        .WithMany()
                        .HasForeignKey("statusid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShipmentСoterie.Tables.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("payMethod");

                    b.Navigation("status");

                    b.Navigation("user");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.OrderList", b =>
                {
                    b.HasOne("ShipmentСoterie.Tables.Order", "order")
                        .WithMany()
                        .HasForeignKey("orderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShipmentСoterie.Tables.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("order");

                    b.Navigation("product");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.Product", b =>
                {
                    b.HasOne("ShipmentСoterie.Tables.Shop", "shop")
                        .WithMany()
                        .HasForeignKey("shopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShipmentСoterie.Tables.ProductType", "type")
                        .WithMany()
                        .HasForeignKey("typeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("shop");

                    b.Navigation("type");
                });

            modelBuilder.Entity("ShipmentСoterie.Tables.User", b =>
                {
                    b.HasOne("ShipmentСoterie.Tables.Profile", "profile")
                        .WithMany()
                        .HasForeignKey("profileid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShipmentСoterie.Tables.Role", "role")
                        .WithMany()
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("profile");

                    b.Navigation("role");
                });
#pragma warning restore 612, 618
        }
    }
}
