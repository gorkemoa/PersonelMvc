﻿// <auto-generated />
using CoreDbMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CoreDbMvc.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230516135329_InitialCreate3")]
    partial class InitialCreate3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CoreDbMvc.Models.Departmanlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Acıklama")
                        .HasColumnType("text");

                    b.Property<string>("DepartmanAd")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Departmanlars");
                });

            modelBuilder.Entity("CoreDbMvc.Models.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<int>("DepartId")
                        .HasColumnType("integer");

                    b.Property<string>("Sehir")
                        .HasColumnType("text");

                    b.Property<string>("Soyad")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DepartId");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("CoreDbMvc.Models.Personel", b =>
                {
                    b.HasOne("CoreDbMvc.Models.Departmanlar", "Depart")
                        .WithMany("Personels")
                        .HasForeignKey("DepartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Depart");
                });

            modelBuilder.Entity("CoreDbMvc.Models.Departmanlar", b =>
                {
                    b.Navigation("Personels");
                });
#pragma warning restore 612, 618
        }
    }
}
