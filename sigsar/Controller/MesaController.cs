using System;
using System.Collections.Generic;
using System.Text;
using sigsar.DAO;
using sigsar.Models;

namespace sigsar.Controllers
{
    public class MesaController
    {
        private readonly MesaDAO mesaDAO = new MesaDAO();
        public List<MesaModel> ListaTablaMesa()
        {
            return mesaDAO.tablaMesas();
        }
        public bool registrarMesa(MesaModel mesa)
        {
            return mesaDAO.InsertarMesa(mesa);
        }
        public bool actualizarMesa(MesaModel mesa)
        {
            return mesaDAO.ActualizarMesa(mesa);
        }

        public bool eliminarMesa(int idMesa)
        {
            return mesaDAO.EliminarMesa(idMesa);
        }
    }
}