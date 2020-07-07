using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Parcial2.Entidades
{
    public class ProyectoDetalle
    {
        [Key]
        public int TareaId { get; set; }
        public string Requirimiento { get; set; }
        public double Tiempo {get; set;}
        

        [ForeignKey("TareaId")]
        public virtual TipoTarea tipotarea { get; set; } = new TipoTarea();
    }
}
