using System;
using System.Collections.Generic;
using System.Text;
using sigsar.DAO;
using sigsar.Models;

namespace sigsar.Controllers
{
    public class RolController
    {
        private readonly RolDAO _rolDAO;

        public RolController()
        {
            _rolDAO = new RolDAO();
        }

        public List<RolModel> ObtenerRoles()
        {
            return _rolDAO.Listar();
        }

        public void RegistrarRol(string descripcion)
        {
            var modelo = new RolModel { Descripcion = descripcion, Estado = true };
            _rolDAO.Registrar(modelo);
        }

        public void ActualizarRol(int id, string descripcion)
        {
            var modelo = new RolModel { Id_Rol = id, Descripcion = descripcion };
            _rolDAO.Actualizar(modelo);
        }

        public void EliminarRol(int id)
        {
            _rolDAO.Eliminar(id);
        }
    }
}
