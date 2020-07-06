using Microsoft.EntityFrameworkCore;
using Parcial2.DAL;
using Parcial2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial2.BLL
{
    public class ProyectosBLL
    {
        //Metodo Existe.
        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                paso = contexto.Ordenes.Any(o => o.ProyectoId == id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        //Metodo Insertar.
        private static bool Insertar(Proyectos proyectos)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Ordenes.Add(proyectos);
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        //Metodo Modificar.
        public static bool Modificar(Proyectos proyectos)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Database.ExecuteSqlRaw($"Delete FROM OrdenesDetalle Where OrdenId={proyectos.ProyectoId}");

                foreach (var anterior in proyectos.OrdenesDetalles)

                {
                    contexto.Entry(anterior).State = EntityState.Added;
                }
                contexto.Entry(proyectos).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        //Metodo Guardar.
        public static bool Guardar(Proyectos proyectos)
        {
            if (!Existe(proyectos.ProyectoId))
                return Insertar(proyectos);
            else
                return Modificar(proyectos);
        }

        //Metodo Buscar.
        public static Proyectos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Proyectos proyectos;

            try
            {
                proyectos = contexto.Proyectos.Include(pr => pr.ProyectoDetalle).Where(p => p.ProyectoId == id).SingleOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return proyectos;
        }

        //Metodo Eliminar.
        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                var orden = contexto.Proyectos.Find(id);
                contexto.Entry(orden).State = EntityState.Deleted;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

    }
}
