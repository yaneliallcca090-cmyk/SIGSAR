using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using sigsar.Config;
using sigsar.Models;

namespace sigsar.DAO
{
    public class MesaDAO
    {
        //aqui, este metodo es para insertar Mesa

        public bool InsertarMesa(MesaModel mesa)
        {
            try
            {
                using (NpgsqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();
                    string sql = @"INSERT INTO mesa 
                           (numero, piso, capacidad) 
                           VALUES 
                           (@numero, @piso, @capacidad);";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@numero", mesa.Numero);
                        cmd.Parameters.AddWithValue("@piso", mesa.Piso);
                        cmd.Parameters.AddWithValue("@capacidad", mesa.Capacidad);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }



        // METODO PARA ACTUALIZAR MESA
        public bool ActualizarMesa(MesaModel mesa)
        {
            try
            {
                using (NpgsqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"UPDATE mesa 
                           SET numero = @numero, 
                               piso = @piso, 
                               capacidad = @capacidad 
                           WHERE id_mesa = @id_mesa;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@numero", mesa.Numero);
                        cmd.Parameters.AddWithValue("@piso", mesa.Piso);
                        cmd.Parameters.AddWithValue("@capacidad", mesa.Capacidad);
                        cmd.Parameters.AddWithValue("@id_mesa", mesa.IdMesa);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        // METODO PARA ELIMINAR MESA
        public bool EliminarMesa(int idMesa)
        {
            try
            {
                using (NpgsqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"DELETE FROM mesa WHERE id_mesa = @id_mesa;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_mesa", idMesa);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        public List<MesaModel> tablaMesas()
        {
            List<MesaModel> lista = new List<MesaModel>();
            try
            {
                using (NpgsqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"SELECT id_mesa, numero, piso, capacidad 
                           FROM mesa 
                           ORDER BY id_mesa ASC;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                MesaModel mesa = new MesaModel();

                                mesa.IdMesa = Convert.ToInt32(dr["id_mesa"]);
                                mesa.Numero = Convert.ToInt32(dr["numero"]); // Ajusta según el tipo de dato en tu modelo (int o string)
                                mesa.Piso = Convert.ToInt32(dr["piso"]);
                                mesa.Capacidad = Convert.ToInt32(dr["capacidad"]);

                                lista.Add(mesa);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar mesas: " + ex.Message);
            }
            return lista;
        }
    }
}
