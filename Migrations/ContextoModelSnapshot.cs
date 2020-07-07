﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial2.DAL;

namespace Parcial2.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5");

            modelBuilder.Entity("Parcial2.Entidades.Proyectos", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.HasKey("ProyectoId");

                    b.ToTable("Proyectos");

                    b.HasData(
                        new
                        {
                            ProyectoId = 1,
                            Descripcion = "Server programado en LUA para la instalacion de scrip.",
                            Fecha = new DateTime(2020, 7, 6, 21, 53, 30, 809, DateTimeKind.Local).AddTicks(2857)
                        },
                        new
                        {
                            ProyectoId = 2,
                            Descripcion = "Realizar un analisis de la empresa.",
                            Fecha = new DateTime(2020, 7, 6, 21, 53, 30, 809, DateTimeKind.Local).AddTicks(4510)
                        },
                        new
                        {
                            ProyectoId = 3,
                            Descripcion = "Diseñar un modelo en UML.",
                            Fecha = new DateTime(2020, 7, 6, 21, 53, 30, 809, DateTimeKind.Local).AddTicks(4558)
                        });
                });

            modelBuilder.Entity("Parcial2.Entidades.TipoTarea", b =>
                {
                    b.Property<int>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ProyectoId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TipodeTarea")
                        .HasColumnType("TEXT");

                    b.HasKey("TareaId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("TipoTarea");

                    b.HasData(
                        new
                        {
                            TareaId = 1,
                            TipodeTarea = "importantes"
                        },
                        new
                        {
                            TareaId = 2,
                            TipodeTarea = "Análisis"
                        },
                        new
                        {
                            TareaId = 3,
                            TipodeTarea = "Diseño"
                        });
                });

            modelBuilder.Entity("Parcial2.Entidades.TipoTarea", b =>
                {
                    b.HasOne("Parcial2.Entidades.Proyectos", null)
                        .WithMany("ProyectoDetalle")
                        .HasForeignKey("ProyectoId");
                });
#pragma warning restore 612, 618
        }
    }
}
