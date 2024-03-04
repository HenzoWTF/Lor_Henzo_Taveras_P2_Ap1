﻿// <auto-generated />
using System;
using Lor_Henzo_Taveras_P2_Ap1.Api.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lor_Henzo_Taveras_P2_Ap1.Api.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240304230608_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Library.Accesorios", b =>
                {
                    b.Property<int>("AccesoriosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AccesoriosId");

                    b.ToTable("Accesorios");
                });

            modelBuilder.Entity("Library.Vehiculo", b =>
                {
                    b.Property<int>("VehiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Costo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Gastos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("VehiculoId");

                    b.ToTable("Vehiculo");
                });

            modelBuilder.Entity("Library.VehiculosDetalle", b =>
                {
                    b.Property<int>("DetalleId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccesorrioId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.Property<int>("VehiculosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DetalleId");

                    b.ToTable("VehiculoDetalle");
                });

            modelBuilder.Entity("Library.VehiculosDetalle", b =>
                {
                    b.HasOne("Library.Vehiculo", null)
                        .WithMany("vehiculosDetalles")
                        .HasForeignKey("DetalleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.Vehiculo", b =>
                {
                    b.Navigation("vehiculosDetalles");
                });
#pragma warning restore 612, 618
        }
    }
}
