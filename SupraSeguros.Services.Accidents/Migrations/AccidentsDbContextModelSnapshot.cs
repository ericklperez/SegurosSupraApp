﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SupraSeguros.Services.Accidents.DbContexts;

#nullable disable

namespace SupraSeguros.Services.Accidents.Migrations
{
    [DbContext(typeof(AccidentsDbContext))]
    partial class AccidentsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Siniestro", b =>
                {
                    b.Property<Guid>("SiniestroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DescripcionSiniestro")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("EstadoSiniestro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("FechaSiniestro")
                        .HasColumnType("date");

                    b.Property<decimal?>("MontoDanios")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<Guid?>("PolizaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SiniestroId");

                    b.ToTable("Siniestro");
                });
#pragma warning restore 612, 618
        }
    }
}