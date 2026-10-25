using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using sigsar.Config;
using sigsar.Models;

namespace sigsar.DAO
{
    public class CategoriaDAO
    {

        //aqui, este metodo es para insertar categoria

        public bool InsertarCategoria(CategoriaModel cat)
        {
            try
            {
                using (NpgsqlConnection cn = Conexion.ObtenerConexion()) //llamamos a la clase(Conexion) y luego a su metodo(ObtenerConexion)
                {
                    cn.Open();

                    string sql = @"INSERT INTO Categoria
                             (nombre, descripcion)
                             VALUES
                             (@nombre, @descripcion);";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", cat.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", cat.Descripcion);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }

            catch (Exception ex)
            {
                return false;
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //METODO PARA ACTUALIZAR CATEGORIA

        public bool ActualizarCategoria(CategoriaModel cat)
        {
            try
            {
                using (NpgsqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"UPDATE categoria
                           SET nombre = @nombre,
                               descripcion = @descripcion
                           WHERE id_categoria = @id_categoria;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", cat.Nombre);
                        cmd.Parameters.AddWithValue("@descripcion", cat.Descripcion);
                        cmd.Parameters.AddWithValue("@id_categoria", cat.IdCategoria);

                        return cmd.ExecuteNonQuery() > 0;
                    }

                }
            }
            catch (Exception ex)
            {
                return false;

                MessageBox.Show(ex.Message.ToString());
            }

        }

        //METODO PARA ELIMINAR CATEGORIA
        public bool EliminarCategoria(int IdCategoria)
        {
            try
            {
                using (NpgsqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"DELETE FROM categoria WHERE id_categoria = @id_categoria;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_categoria", IdCategoria);

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


        public List<CategoriaModel> tablaCategorias()
        {
            List<CategoriaModel> lista = new List<CategoriaModel>();
            try
            {
                using (NpgsqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"SELECT id_categoria, nombre, descripcion
                           FROM categoria
                           ORDER BY id_categoria ASC;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                CategoriaModel cat = new CategoriaModel();

                                cat.IdCategoria = Convert.ToInt32(dr["id_categoria"]);
                                cat.Nombre = dr["nombre"].ToString();
                                cat.Descripcion = dr["descripcion"].ToString();

                                lista.Add(cat);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar categorias: " + ex.Message);
            }
            return lista;
        }




       
    }

}