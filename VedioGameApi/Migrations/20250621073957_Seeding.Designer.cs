﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VedioGameApi.Data;

#nullable disable

namespace VedioGameApi.Migrations
{
    [DbContext(typeof(VideoGameDbContext))]
    [Migration("20250621073957_Seeding")]
    partial class Seeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("VedioGameApi.VedioGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Developer = "Insomniac Games",
                            Platform = "PS5",
                            Publisher = "Sony Interactive Entertainment",
                            Title = "Spider-Man 2"
                        },
                        new
                        {
                            Id = 2,
                            Developer = "Santa Monicafhghg Studio",
                            Platform = "PS10",
                            Publisher = "Sony Interactive Entertainment",
                            Title = "God of War Ragnafdg"
                        },
                        new
                        {
                            Id = 3,
                            Developer = "343 Industries",
                            Platform = "Xbox Series X",
                            Publisher = "Xbox Game Studios",
                            Title = "Halo Infinite"
                        },
                        new
                        {
                            Id = 4,
                            Developer = "Nintendo",
                            Platform = "Nintendo Switch",
                            Publisher = "Nintendo",
                            Title = "The Legend of Zelda: Tears of the Kingdom"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
