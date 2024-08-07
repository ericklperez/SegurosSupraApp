﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SupraSeguros.Services.Payments.DbContexts;

#nullable disable

namespace SupraSeguros.Services.Payments.Migrations
{
    [DbContext(typeof(PaymentsDbContext))]
    [Migration("20240726174024_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AcuerdoPago", b =>
                {
                    b.Property<Guid>("AcuerdoPagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EstadoAcuerdo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("FechaFin")
                        .HasColumnType("date");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("date");

                    b.Property<decimal?>("MontoAcordado")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<Guid?>("PolizaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AcuerdoPagoId");

                    b.ToTable("AcuerdoPago");
                });

            modelBuilder.Entity("Pago", b =>
                {
                    b.Property<Guid>("PagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("EstadoPago")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("FechaPago")
                        .HasColumnType("date");

                    b.Property<string>("MetodoPago")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal?>("Monto")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<Guid?>("PolizaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PagoId");

                    b.ToTable("Pago");
                });

            modelBuilder.Entity("ServicioPago", b =>
                {
                    b.Property<Guid>("ServicioPagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Costo")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Proveedor")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ServicioPagoId");

                    b.ToTable("ServicioPago");
                });
#pragma warning restore 612, 618
        }
    }
}
