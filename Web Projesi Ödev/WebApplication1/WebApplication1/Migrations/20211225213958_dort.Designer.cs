﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.data;

namespace WebApplication1.Migrations
{
    [DbContext(typeof(KediDbContext))]
    [Migration("20211225213958_dort")]
    partial class dort
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Models.Admin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acıklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Unvan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isim")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("WebApplication1.Models.Balik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fiyat")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Balik");
                });

            modelBuilder.Entity("WebApplication1.Models.Kedi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fiyat")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kedi");
                });

            modelBuilder.Entity("WebApplication1.Models.Kopek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fiyat")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kopek");
                });

            modelBuilder.Entity("WebApplication1.Models.Kus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fiyat")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Kus");
                });
#pragma warning restore 612, 618
        }
    }
}
