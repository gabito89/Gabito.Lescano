﻿using System;
using System.ComponentModel;

namespace AdSanare.Entities
{
    [Serializable]
    public class Cama
    {
        public int Id { get; set; }
        public virtual Servicio ServicioInternacion { get; set; }
        [DisplayName("Número/Letra de Cama")]
        public string Descripcion { get; set; }
        public bool BajaLogica { get; set; }
        public DateTime FechaBaja { get; set; }
    }
}