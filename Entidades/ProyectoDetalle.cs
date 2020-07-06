using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial2.Entidades
{
    public class ProyectoDetalle
    {
        [Key]
        public string TipoTarea { get; set; }
        public string Requirimiento { get; set; }
        public float Tiempo {get; set;}

        public ProyectoDetalle(string tipoTarea, string requirimiento, float tiempo)
        {
            TipoTarea = tipoTarea;
            Requirimiento = requirimiento;
            Tiempo = tiempo;
        }
    }
}
