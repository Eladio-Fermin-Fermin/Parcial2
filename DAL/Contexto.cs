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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\ProyectosD.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ProyectoDetalle>().HasData(new ProyectoDetalle { TipoTarea = 1, Nombres = "Eladio" });

            modelBuilder.Entity<Proyectos>().HasData(new Proyectos
            {
                ProyectoId = 1,
                Fecha = DateTime.Now,
                Descripcion = "Server programado en LUA para la instalacion de scrip",
            });

            modelBuilder.Entity<Proyectos>().HasData(new Proyectos
            {
                ProyectoId = 2,
                Fecha = DateTime.Now,
                Descripcion = "SQL Server 2012",
            });

            modelBuilder.Entity<Proyectos>().HasData(new Proyectos
            {
                ProyectoId = 3,
                Fecha = DateTime.Now,
                Descripcion = "SQL Server 2014",
            });

            modelBuilder.Entity<Proyectos>().HasData(new Proyectos
            {
                ProyectoId = 4,
                Fecha = DateTime.Now,
                Descripcion = "Segundo Parcial",
            });

            modelBuilder.Entity<Proyectos>().HasData(new Proyectos
            {
                ProyectoId = 5,
                Fecha = DateTime.Now,
                Descripcion = "Diseño de Solicitud de forma WEB",
            });

        }

    }
}
