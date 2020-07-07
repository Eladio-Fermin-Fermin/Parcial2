using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Parcial2.Entidades
{
    public class TipoTarea
    {
        [Key]
        public int TareaId { get; set; }
        public string TipodeTarea { get; set; }
    }
}
