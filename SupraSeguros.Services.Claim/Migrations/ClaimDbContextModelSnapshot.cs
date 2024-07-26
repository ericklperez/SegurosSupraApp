﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SupraSeguros.Services.Claim.DbContexts;

#nullable disable

namespace SupraSeguros.Services.Claim.Migrations
{
    [DbContext(typeof(ClaimDbContext))]
    partial class ClaimDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Reclamacion", b =>
                {
                    b.Property<Guid>("ReclamacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("FechaReclamacion")
                        .HasColumnType("date");

                    b.Property<decimal?>("MontoAprobado")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal?>("MontoReclamado")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<Guid?>("PolizaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ReclamacionId");

                    b.ToTable("Reclamacion");
                });
#pragma warning restore 612, 618
        }
    }
}
