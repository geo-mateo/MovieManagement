﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieManagement.Persistance;

#nullable disable

namespace MovieManagement.Persistance.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20220630141703_behav5")]
    partial class behav5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MovieManagement.Domain.Entities.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Inactivated")
                        .HasColumnType("datetime2");

                    b.Property<string>("InactivatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Directors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2022, 6, 30, 16, 17, 3, 159, DateTimeKind.Local).AddTicks(1990),
                            StatusId = 1
                        });
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.DirectorBiography", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DoB")
                        .HasColumnType("datetime2");

                    b.Property<string>("PlaceOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId")
                        .IsUnique();

                    b.ToTable("DirectorBiographies");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("PremierYear")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2000);

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.HasIndex("GenreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DirectorId = 1,
                            Name = "Pan Tadeusz",
                            PremierYear = 0
                        },
                        new
                        {
                            Id = 2,
                            DirectorId = 1,
                            Name = "Popiół i Diament",
                            PremierYear = 0
                        });
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Director", b =>
                {
                    b.OwnsOne("MovieManagement.Domain.ValueObjects.PersonName", "DirectorName", b1 =>
                        {
                            b1.Property<int>("DirectorId")
                                .HasColumnType("int");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("FirstName");

                            b1.Property<string>("LastName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("LastName");

                            b1.HasKey("DirectorId");

                            b1.ToTable("Directors");

                            b1.WithOwner()
                                .HasForeignKey("DirectorId");

                            b1.HasData(
                                new
                                {
                                    DirectorId = 1,
                                    FirstName = "Andrzej",
                                    LastName = "Wajda"
                                });
                        });

                    b.Navigation("DirectorName")
                        .IsRequired();
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.DirectorBiography", b =>
                {
                    b.HasOne("MovieManagement.Domain.Entities.Director", "Director")
                        .WithOne("DirectorBiography")
                        .HasForeignKey("MovieManagement.Domain.Entities.DirectorBiography", "DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Director");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Movie", b =>
                {
                    b.HasOne("MovieManagement.Domain.Entities.Director", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieManagement.Domain.Entities.Genre", null)
                        .WithMany("Movies")
                        .HasForeignKey("GenreId");

                    b.Navigation("Director");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Director", b =>
                {
                    b.Navigation("DirectorBiography");

                    b.Navigation("Movies");
                });

            modelBuilder.Entity("MovieManagement.Domain.Entities.Genre", b =>
                {
                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
