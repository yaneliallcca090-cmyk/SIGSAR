using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using sigsar.Config;
using sigsar.Models;

namespace sigsar.DAO
{
    public class RolDAO
    {
        public List<RolModel> Listar()
        {
            var lista = new List<RolModel>();
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                string query = "SELECT id_rol, descripcion, estado FROM rol";
                using (var cmd = new NpgsqlCommand(query, conexion))
                {
                    using (var lector = cmd.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            lista.Add(new RolModel
                            {
                                Id_Rol = lector.GetInt32(0),
                                Descripcion = lector.GetString(1),
                                Estado = lector.GetBoolean(2)
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public void Registrar(RolModel model)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                string query = "INSERT INTO rol (descripcion, estado) VALUES (@descripcion, @estado)";
                using (var cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@descripcion", model.Descripcion);
                    cmd.Parameters.AddWithValue("@estado", model.Estado);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Actualizar(RolModel model)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                string query = "UPDATE rol SET descripcion = @descripcion WHERE id_rol = @id";
                using (var cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@descripcion", model.Descripcion);
                    cmd.Parameters.AddWithValue("@id", model.Id_Rol);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var conexion = Conexion.ObtenerConexion())
            {
                conexion.Open();
                string query = "DELETE FROM rol WHERE id_rol = @id";
                using (var cmd = new NpgsqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}