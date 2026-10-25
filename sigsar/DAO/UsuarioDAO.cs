using Npgsql;
using sigsar.Config;
using sigsar.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace sigsar.DAO
{
    public class UsuarioDAO
    {
        // Método para insertar un nuevo usuario
        public bool InsertarUsuario(UsuarioModel usu)
        {
            try
            {
                using (NpgsqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"INSERT INTO usuario (id_rol, dni, apellidos,
                                                       nombres, genero, celular,
                                                       email, direccion, clave_hash)
                                                VALUES (@id_rol, @dni, @apellidos,
                                                       @nombres, @genero, @celular,
                                                       @email, @direccion, @clave_hash);";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_rol", usu.IdRol);
                        cmd.Parameters.AddWithValue("@dni", usu.Dni);
                        cmd.Parameters.AddWithValue("@apellidos", usu.Apellidos);
                        cmd.Parameters.AddWithValue("@nombres", usu.Nombres);
                        cmd.Parameters.AddWithValue("@genero", usu.Genero);
                        cmd.Parameters.AddWithValue("@celular", usu.Celular);
                        cmd.Parameters.AddWithValue("@email", usu.Email);
                        cmd.Parameters.AddWithValue("@direccion", usu.Direccion);
                        cmd.Parameters.AddWithValue("@clave_hash", usu.ClaveHash);

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

        // METODO PARA ACTUALIZAR USUARIO
        public bool ActualizarUsuario(UsuarioModel usu)
        {
            try
            {
                using (NpgsqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"UPDATE usuario 
                           SET id_rol = @id_rol, 
                               dni = @dni, 
                               apellidos = @apellidos, 
                               nombres = @nombres, 
                               genero = @genero, 
                               celular = @celular, 
                               email = @email, 
                               direccion = @direccion, 
                               clave_hash = @clave_hash
                           WHERE id_usuario = @id_usuario;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", usu.IdUsuario);
                        cmd.Parameters.AddWithValue("@id_rol", usu.IdRol);
                        cmd.Parameters.AddWithValue("@dni", usu.Dni);
                        cmd.Parameters.AddWithValue("@apellidos", usu.Apellidos);
                        cmd.Parameters.AddWithValue("@nombres", usu.Nombres);
                        cmd.Parameters.AddWithValue("@genero", usu.Genero);
                        cmd.Parameters.AddWithValue("@celular", usu.Celular);
                        cmd.Parameters.AddWithValue("@email", usu.Email);
                        cmd.Parameters.AddWithValue("@direccion", usu.Direccion);
                        cmd.Parameters.AddWithValue("@clave_hash", usu.ClaveHash);

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

        // MÉTODO PARA ELIMINAR USUARIO
        public bool EliminarUsuario(int IdUsuario)
        {
            try
            {
                using (NpgsqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"DELETE FROM usuario WHERE id_usuario = @id_usuario;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", IdUsuario);

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


        public List<UsuarioModel> tablaUsuarios()
        {
            List<UsuarioModel> lista = new List<UsuarioModel>();
            try
            {
                using (NpgsqlConnection cn = Conexion.ObtenerConexion())
                {
                    cn.Open();

                    string sql = @"SELECT id_usuario, id_rol, dni, apellidos, nombres, 
                                          genero, celular, email, direccion, clave_hash, estado, fecha_ingreso 
                                     FROM usuario 
                                     ORDER BY id_usuario ASC;";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, cn))
                    {
                        using (NpgsqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                UsuarioModel usu = new UsuarioModel();

                                usu.IdUsuario = Convert.ToInt32(dr["id_usuario"]);
                                usu.IdRol = Convert.ToInt32(dr["id_rol"]);
                                usu.Dni = dr["dni"].ToString();
                                usu.Apellidos = dr["apellidos"].ToString();
                                usu.Nombres = dr["nombres"].ToString();
                                usu.Genero = Convert.ToChar(dr["genero"]);
                                usu.Celular = dr["celular"].ToString();
                                usu.Email = dr["email"].ToString();
                                usu.Direccion = dr["direccion"].ToString();
                                usu.ClaveHash = dr["clave_hash"].ToString();
                                usu.Estado = Convert.ToBoolean(dr["estado"]);
                                usu.FechaIngreso = DateTime.Parse(dr["fecha_ingreso"].ToString());

                                lista.Add(usu);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar usuarios: " + ex.Message);
            }
            return lista;
        }
    }

}
