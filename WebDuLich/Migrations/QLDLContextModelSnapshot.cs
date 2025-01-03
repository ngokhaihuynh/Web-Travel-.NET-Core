﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebDuLich.Models;

namespace WebDuLich.Migrations
{
    [DbContext(typeof(QLDLContext))]
    partial class QLDLContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebDuLich.Models.Account", b =>
                {
                    b.Property<int>("AccId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Access")
                        .HasColumnType("int")
                        .HasColumnName("access");

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime")
                        .HasColumnName("createDate");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Encode")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true);

                    b.Property<string>("FullName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("AccId")
                        .HasName("PK__ACCOUNTS__91CBC378D8DDA719");

                    b.HasIndex("RoleId");

                    b.ToTable("ACCOUNTS");
                });

            modelBuilder.Entity("WebDuLich.Models.Category", b =>
                {
                    b.Property<int>("CatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatName")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("Levels")
                        .HasColumnType("int")
                        .HasColumnName("levels");

                    b.Property<int?>("Location")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<bool?>("Publish")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("CatId")
                        .HasName("PK__CATEGORI__6A1C8AFA05CE9600");

                    b.ToTable("CATEGORIES");
                });

            modelBuilder.Entity("WebDuLich.Models.Customer", b =>
                {
                    b.Property<int>("CusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Avata")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("District")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Encode")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true);

                    b.Property<string>("FullName")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime?>("LastLogin")
                        .HasColumnType("datetime");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("Ward")
                        .HasColumnType("int");

                    b.HasKey("CusId")
                        .HasName("PK__CUSTOMER__2F187110F9E49177");

                    b.HasIndex("LocationId");

                    b.ToTable("CUSTOMERS");
                });

            modelBuilder.Entity("WebDuLich.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Levels")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Namewithtype")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("ParentCode")
                        .HasColumnType("int");

                    b.Property<string>("Pathwithtype")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Slug")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("LocationId");

                    b.ToTable("LOCATIONS");
                });

            modelBuilder.Entity("WebDuLich.Models.News", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccId")
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("CatId")
                        .HasColumnType("int");

                    b.Property<string>("Contents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Image")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool?>("IsHot")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsNewFeed")
                        .HasColumnType("bit");

                    b.Property<string>("MetaDesc")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("MetaKey")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool?>("Publish")
                        .HasColumnType("bit");

                    b.Property<string>("ShortContent")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tile")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("Views")
                        .HasColumnType("int");

                    b.HasKey("PostId")
                        .HasName("PK__NEWS__AA12601876C0BC79");

                    b.HasIndex("AccId");

                    b.HasIndex("CatId");

                    b.ToTable("NEWS");
                });

            modelBuilder.Entity("WebDuLich.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CusId")
                        .HasColumnType("int");

                    b.Property<bool?>("Deteled")
                        .HasColumnType("bit");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<bool?>("Paid")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("PaymentDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("PaymentId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ShipDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("TransactId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CusId");

                    b.HasIndex("TransactId");

                    b.ToTable("ORDERS");
                });

            modelBuilder.Entity("WebDuLich.Models.Orderdetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<int?>("Location")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderNumber")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("Quantity")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ShipDate")
                        .HasColumnType("datetime");

                    b.Property<int?>("Total")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("ORDERDETAILS");
                });

            modelBuilder.Entity("WebDuLich.Models.Page", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Image")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("MetaDesc")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("MetaKey")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("PageName")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool?>("Publish")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("PageId");

                    b.ToTable("PAGES");
                });

            modelBuilder.Entity("WebDuLich.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("Actice")
                        .HasColumnType("bit");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("BestSeller")
                        .HasColumnType("bit");

                    b.Property<int?>("CatId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime");

                    b.Property<DateTime?>("CreateModified")
                        .HasColumnType("datetime");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Discount")
                        .HasColumnType("int");

                    b.Property<bool?>("HomeFlag")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("MetaDesc")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("MetaKey")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("Price")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ShortDesc")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int?>("StockingTour")
                        .HasColumnType("int");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("title");

                    b.Property<string>("Video")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasColumnName("video");

                    b.HasKey("ProductId");

                    b.HasIndex("CatId");

                    b.ToTable("PRODUCTS");
                });

            modelBuilder.Entity("WebDuLich.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("RoleName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RoleId");

                    b.ToTable("ROLES");
                });

            modelBuilder.Entity("WebDuLich.Models.Transactstatus", b =>
                {
                    b.Property<int>("TransactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TransactId")
                        .HasName("PK__TRANSACT__4400DE5519308CAD");

                    b.ToTable("TRANSACTSTATUS");
                });

            modelBuilder.Entity("WebDuLich.Models.Account", b =>
                {
                    b.HasOne("WebDuLich.Models.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK__ACCOUNTS__RoleId__276EDEB3");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("WebDuLich.Models.Customer", b =>
                {
                    b.HasOne("WebDuLich.Models.Location", "Location")
                        .WithMany("Customers")
                        .HasForeignKey("LocationId")
                        .HasConstraintName("FK__CUSTOMERS__Locat__173876EA");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("WebDuLich.Models.News", b =>
                {
                    b.HasOne("WebDuLich.Models.Account", "Acc")
                        .WithMany("News")
                        .HasForeignKey("AccId")
                        .HasConstraintName("FK__NEWS__AccId__2B3F6F97");

                    b.HasOne("WebDuLich.Models.Category", "Cat")
                        .WithMany("News")
                        .HasForeignKey("CatId")
                        .HasConstraintName("FK__NEWS__CatId__2A4B4B5E");

                    b.Navigation("Acc");

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("WebDuLich.Models.Order", b =>
                {
                    b.HasOne("WebDuLich.Models.Customer", "Cus")
                        .WithMany("Orders")
                        .HasForeignKey("CusId")
                        .HasConstraintName("FK__ORDERS__CusId__1BFD2C07");

                    b.HasOne("WebDuLich.Models.Transactstatus", "Transact")
                        .WithMany("Orders")
                        .HasForeignKey("TransactId")
                        .HasConstraintName("FK__ORDERS__Transact__1CF15040");

                    b.Navigation("Cus");

                    b.Navigation("Transact");
                });

            modelBuilder.Entity("WebDuLich.Models.Orderdetail", b =>
                {
                    b.HasOne("WebDuLich.Models.Order", "Order")
                        .WithMany("Orderdetails")
                        .HasForeignKey("OrderId")
                        .HasConstraintName("FK__ORDERDETA__Order__1FCDBCEB");

                    b.HasOne("WebDuLich.Models.Product", "Product")
                        .WithMany("Orderdetails")
                        .HasForeignKey("ProductId")
                        .HasConstraintName("FK__ORDERDETA__Produ__20C1E124");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("WebDuLich.Models.Product", b =>
                {
                    b.HasOne("WebDuLich.Models.Category", "Cat")
                        .WithMany("Products")
                        .HasForeignKey("CatId")
                        .HasConstraintName("FK__PRODUCTS__CatId__1273C1CD");

                    b.Navigation("Cat");
                });

            modelBuilder.Entity("WebDuLich.Models.Account", b =>
                {
                    b.Navigation("News");
                });

            modelBuilder.Entity("WebDuLich.Models.Category", b =>
                {
                    b.Navigation("News");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebDuLich.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("WebDuLich.Models.Location", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("WebDuLich.Models.Order", b =>
                {
                    b.Navigation("Orderdetails");
                });

            modelBuilder.Entity("WebDuLich.Models.Product", b =>
                {
                    b.Navigation("Orderdetails");
                });

            modelBuilder.Entity("WebDuLich.Models.Role", b =>
                {
                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("WebDuLich.Models.Transactstatus", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
