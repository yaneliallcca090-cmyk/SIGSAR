using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace sigsar.Config
{
    public class Conexion
    {
         private static string ObtenerCadenaConexion()
         {
            string cadenaConexion = @"Host=localhost;
                                    Port=5432;
                                    Database=sigsar;
                                    Username=postgres;
                                    Password=admin;";

            /* if (string.IsNullOrWhiteSpace(cadenaConexion)) ... */

            return cadenaConexion;
        }

        public static NpgsqlConnection ObtenerConexion()
        {
            return new NpgsqlConnection(ObtenerCadenaConexion());
        }
    }
}
