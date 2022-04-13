﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AG.Book.Api.Migrations
{
    [DbContext(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AG.Book.Api.Data.Entities.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Anthony Burgess",
                            Created = new DateTime(2022, 4, 9, 22, 46, 38, 283, DateTimeKind.Local).AddTicks(8299),
                            Name = "Otomatik Portakal",
                            Price = 20m
                        },
                        new
                        {
                            Id = 2,
                            Author = "Anthony Burgess",
                            Created = new DateTime(2022, 4, 9, 22, 46, 38, 283, DateTimeKind.Local).AddTicks(8313),
                            Name = "Otomatik Portakal",
                            Price = 20m
                        },
                        new
                        {
                            Id = 3,
                            Author = "Anthony Burgess",
                            Created = new DateTime(2022, 4, 9, 22, 46, 38, 283, DateTimeKind.Local).AddTicks(8316),
                            Name = "Otomatik Portakal",
                            Price = 20m
                        },
                        new
                        {
                            Id = 4,
                            Author = "Anthony Burgess",
                            Created = new DateTime(2022, 4, 9, 22, 46, 38, 283, DateTimeKind.Local).AddTicks(8319),
                            Name = "Otomatik Portakal",
                            Price = 20m
                        },
                        new
                        {
                            Id = 5,
                            Author = "Anthony Burgess",
                            Created = new DateTime(2022, 4, 9, 22, 46, 38, 283, DateTimeKind.Local).AddTicks(8321),
                            Name = "Otomatik Portakal",
                            Price = 20m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
