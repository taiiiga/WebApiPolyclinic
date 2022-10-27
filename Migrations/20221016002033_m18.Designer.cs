﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApiPolyclinic.Infrastructure;

#nullable disable

namespace WebApiPolyclinic.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221016002033_m18")]
    partial class m18
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc.1.22426.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApiPolyclinic.Entities.Analyze", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PatientId")
                        .HasColumnType("integer");

                    b.Property<string>("Result")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Analyzes");
                });

            modelBuilder.Entity("WebApiPolyclinic.Entities.Diagnose", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<DateTime?>("DateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RecordId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("WebApiPolyclinic.Entities.Doctor", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Doctors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Specialization = "Хирург",
                            UserId = 13
                        });
                });

            modelBuilder.Entity("WebApiPolyclinic.Entities.Record", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<int?>("ClientId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("DoctorId")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool?>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("WebApiPolyclinic.Entities.Role", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Админ"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Пациент"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Доктор"
                        });
                });

            modelBuilder.Entity("WebApiPolyclinic.Entities.User", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int?>("Id"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            City = "",
                            Email = "admin@mail.com",
                            FirstName = "",
                            LastName = "",
                            Password = "admin",
                            Phone = "",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            City = "",
                            Email = "client@mail.com",
                            FirstName = "",
                            LastName = "",
                            Password = "client",
                            Phone = "",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 3,
                            City = "",
                            Email = "doctor@mail.com",
                            FirstName = "",
                            LastName = "",
                            Password = "doctor",
                            Phone = "",
                            RoleId = 3
                        },
                        new
                        {
                            Id = 11,
                            City = "",
                            Email = "admin@gmail.com",
                            FirstName = "Админ",
                            LastName = "Админов",
                            Password = "admin",
                            Phone = "",
                            RoleId = 1
                        },
                        new
                        {
                            Id = 12,
                            City = "",
                            Email = "vanov@gmail.com",
                            FirstName = "Ваня",
                            LastName = "Ванов",
                            Password = "123456",
                            Phone = "+79443453535",
                            RoleId = 2
                        },
                        new
                        {
                            Id = 13,
                            City = "",
                            Email = "ivan@gmail.com",
                            FirstName = "Иван",
                            LastName = "Иванов",
                            Password = "123456",
                            Phone = "+79443453534",
                            RoleId = 3
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
