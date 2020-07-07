using Parcial2.DAL;
using System;
using Parcial2.Entidades;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Parcial2.BLL
{
    public class TipoTareaBLL
    {
  

        public static List<TipoTarea> GetTipoTarea()
        {
            Contexto contexto = new Contexto();
            List<TipoTarea> tipotarea = new List<TipoTarea>();

            try
            {
                tipotarea = contexto.TipoTarea.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return tipotarea;
        }

    }
}
