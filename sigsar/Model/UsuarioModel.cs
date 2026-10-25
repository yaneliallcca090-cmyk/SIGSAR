using System;
using System.Collections.Generic;
using System.Text;

namespace sigsar.Model
{
    public class UsuarioModel
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Dni { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public char Genero { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string ClaveHash { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
