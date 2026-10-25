using System;
using System.Collections.Generic;
using System.Text;

namespace sigsar.Models
{
    public class CategoriaModel //Aqui declaramos la clase publica que servira como
    {                           // como un objeto contenedor para representar una categoria.
        public int IdCategoria { get; set; } //Define la propiedad numérica que el controlador llena cuando necesita
                                    //identificar una fila específica (como en la actualización).
        public string Nombre { get; set; } //Define la propiedad de texto que el controlador llena con lo que escribe el usuario.
    
        public string Descripcion { get; set; } 

        public bool Estado { get; set; }    

        public DateTime FechaCrea { get; set; }

        }
}
