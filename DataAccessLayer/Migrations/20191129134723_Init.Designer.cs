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
    [Migration("20191129134723_Init")]
    partial class Init
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