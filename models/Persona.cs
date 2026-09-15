using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
				private readonly string cadenaConexion = @"";

		}
}