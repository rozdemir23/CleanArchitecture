// <auto-generated />
using System;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220809180833_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Master.Depo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("DAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DAdres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DTarih")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Depo");
                });

            modelBuilder.Entity("Domain.Master.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Birim_Fiyati")
                        .HasColumnType("integer");

                    b.Property<string>("Giris_Yap_Depo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SAdet")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Tarih")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Tedarikci")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Siparis");
                });

            modelBuilder.Entity("Domain.Master.Tedarik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tarih")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tedarik");
                });

            modelBuilder.Entity("Domain.Master.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Tarih")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Tip")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UAdi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Urun");
                });
#pragma warning restore 612, 618
        }
    }
}
