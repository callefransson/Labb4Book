﻿// <auto-generated />
using System;
using Labb4Book.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb4Book.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240427170638_Added nullable to ICollections")]
    partial class AddednullabletoICollections
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Labb4Book.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<DateTime>("BookRentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BookReturnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Labb4Book.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("CutsomerEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("CutsomerFirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CutsomerLastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CutsomerPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Labb4Book.Models.CustomerBook", b =>
                {
                    b.Property<int>("CustomerBookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerBookId"));

                    b.Property<int>("FkBookId")
                        .HasColumnType("int");

                    b.Property<int>("FkCustomerId")
                        .HasColumnType("int");

                    b.HasKey("CustomerBookId");

                    b.HasIndex("FkBookId");

                    b.HasIndex("FkCustomerId");

                    b.ToTable("BooksBook");
                });

            modelBuilder.Entity("Labb4Book.Models.CustomerBook", b =>
                {
                    b.HasOne("Labb4Book.Models.Book", "Book")
                        .WithMany("CustomerBooks")
                        .HasForeignKey("FkBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb4Book.Models.Customer", "Customer")
                        .WithMany("CustomerBooks")
                        .HasForeignKey("FkCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Labb4Book.Models.Book", b =>
                {
                    b.Navigation("CustomerBooks");
                });

            modelBuilder.Entity("Labb4Book.Models.Customer", b =>
                {
                    b.Navigation("CustomerBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
