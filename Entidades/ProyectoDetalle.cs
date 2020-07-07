using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial2.Entidades
{
    public class ProyectoDetalle
    {
        [Key]
        public string Requirimiento { get; set; }
        public float Tiempo {get; set;}

        public ProyectoDetalle(string requirimiento, float tiempo)
        {
            Requirimiento = requirimiento;
            Tiempo = tiempo;
        }
    }
}
