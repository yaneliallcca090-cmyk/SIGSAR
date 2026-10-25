using System;
using System.Collections.Generic;
using System.Text;

namespace sigsar.Models
{
    public class MesaModel
    {
        public int IdMesa { get; set; }
        public int Numero { get; set; }
        public int Piso { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCrea { get; set; }
    }
}
