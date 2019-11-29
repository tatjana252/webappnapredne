﻿// <auto-generated />
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(ZaposleniDbContext))]
    [Migration("20191129135243_Seed")]
    partial class Seed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DataAccessLayer.Models.Odeljenje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("Odeljenja");

                    b.HasData(
                        new { Id = 1, Naziv = "Finansije" },
                        new { Id = 2, Naziv = "Prodaja" }
                    );
                });

            modelBuilder.Entity("DataAccessLayer.Models.Zaposleni", b =>
                {
                    b.Property<int>("ZaposleniId");

                    b.Property<string>("Ime")
                        .IsRequired();

                    b.Property<int>("OdeljenjeId");

                    b.Property<string>("Prezime")
                        .IsRequired();

                    b.HasKey("ZaposleniId");

                    b.HasIndex("OdeljenjeId");

                    b.ToTable("Zaposleni");

                    b.HasData(
                        new { ZaposleniId = 1, Ime = "Pera", OdeljenjeId = 2, Prezime = "Peric" }
                    );
                });

            modelBuilder.Entity("DataAccessLayer.Models.Zaposleni", b =>
                {
                    b.HasOne("DataAccessLayer.Models.Odeljenje", "Odeljenje")
                        .WithMany()
                        .HasForeignKey("OdeljenjeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
