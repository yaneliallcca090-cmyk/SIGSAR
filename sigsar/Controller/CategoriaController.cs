using sigsar.DAO;     //Permiten que el controlador conozca y utilice las clases de acceso a datos,
using sigsar.Models;  //y las estructuras de datos
using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Text;


namespace sigsar.Controllers  //Define el lugar o carpeta del proyecto donde esta este codigo.
{
    public class CategoriaController
    {
        private readonly CategoriaDAO catDAO = new CategoriaDAO();   //instancia(copiar un molde)

        public List<CategoriaModel> ListaTablaCategoria()
        {
            return catDAO.tablaCategorias();
        }
        public bool registrarCategoria(CategoriaModel cat)
        {
            return catDAO.InsertarCategoria(cat);
        }
        public bool actualizarCategoria(CategoriaModel cat)
        {
            return catDAO.ActualizarCategoria(cat);
        }
        public bool eliminarCategoria(int idCategoria)
        {
            return catDAO.EliminarCategoria(idCategoria);
        }
    }
}