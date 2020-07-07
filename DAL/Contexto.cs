using Microsoft.EntityFrameworkCore;
using Parcial2.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parcial2.DAL
{
    public class Contexto : DbContext
    {

        public DbSet<Proyectos> Proyectos { get; set; }
        public DbSet<TipoTarea> TipoTarea { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\ProyectosD.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProyectoDetalle>().HasData(new ProyectoDetalle { TipoTarea = 1 });
            modelBuilder.Entity<TipoTarea>().HasData(new TipoTarea { TareaId = 1, TipodeTarea = "importantes" });
            modelBuilder.Entity<TipoTarea>().HasData(new TipoTarea { TareaId = 2, TipodeTarea = "Análisis" });
            modelBuilder.Entity<TipoTarea>().HasData(new TipoTarea { TareaId = 3, TipodeTarea = "Diseño" });
            modelBuilder.Entity<TipoTarea>().HasData(new TipoTarea { TareaId = 4, TipodeTarea = "Prueba" });
            modelBuilder.Entity<TipoTarea>().HasData(new TipoTarea { TareaId = 5, TipodeTarea = "Programacion" });

            modelBuilder.Entity<Proyectos>().HasData(new Proyectos
            {
                ProyectoId = 1,
                Fecha = DateTime.Now,
                Descripcion = "Server programado en LUA para la instalacion de scrip.",
            });

            modelBuilder.Entity<Proyectos>().HasData(new Proyectos
            {
                ProyectoId = 2,
                Fecha = DateTime.Now,
                Descripcion = "Realizar un analisis de la empresa.",
            });

            modelBuilder.Entity<Proyectos>().HasData(new Proyectos
            {
                ProyectoId = 3,
                Fecha = DateTime.Now,
                Descripcion = "Diseñar un modelo en UML.",
            });

        }

    }
}
