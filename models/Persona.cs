using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace practica_form_duna.models
{
    /// <summary>
    ///  Modelo DTO de la tabla persona
    /// </summary>
    internal class Persona
    {
        public long? id { get; private set; }
        public string nombre { get; private set; }
        public string telefono { get; private set; }
        //cadena de conexion de mysql

        public Persona(long? id, string nombre, string telefono)
        {
            this.id = id ?? 0;
            this.nombre = nombre;
            this.telefono = telefono;
        }

        // IMPORTANTE: Aqui va todo el sql
        private static readonly string cadenaConexion = @"Server=localhost\SQLEXPRESS;Database=db_practica;Trusted_Connection=True;TrustServerCertificate=True;";

        public static List<Persona> getAll()
        {
            List<Persona> listaPersonas = new List<Persona>();
            string query = "SELECT id, nombre, telefono FROM Persona";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Mapeamos cada fila a un objeto Persona
                                Persona persona = new Persona(
                                    Convert.ToInt64(reader["id"]),
                                    reader["nombre"].ToString(),
                                    reader["telefono"].ToString()
                                );

                                listaPersonas.Add(persona);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Ahora sí devolvemos la lista correctamente
            return listaPersonas;
        }
    }
}