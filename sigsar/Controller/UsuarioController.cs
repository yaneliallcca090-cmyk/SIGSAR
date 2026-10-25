using sigsar.DAO;
using sigsar.Model;
using sigsar.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace sigsar.Controller
{
    public class UsuarioController
    {
        private readonly UsuarioDAO usuDAO = new UsuarioDAO();

        public bool registrarUsuario(UsuarioModel usu)
        {
            return usuDAO.InsertarUsuario(usu);
        }
        public List<UsuarioModel> listarUsuarios()
        {
            return usuDAO.tablaUsuarios();
        }
        public bool actualizarUsuario(UsuarioModel usu)
        {
            return usuDAO.ActualizarUsuario(usu);
        }
        public bool eliminarUsuario(int idUsuario)
        {
            return usuDAO.EliminarUsuario(idUsuario);
        }
    }

}
