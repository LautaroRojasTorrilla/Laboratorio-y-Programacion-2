using System.Data.SqlClient;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades.DataBase 
{
    public class GestorBaseDeDatos : IGuardar<AutoF1>
    {
        private static string cadenaConexion;
        
        
        static GestorBaseDeDatos()
        {
            GestorBaseDeDatos.cadenaConexion = "Server=.;Database=20210717-RSP;Trusted_Connection=True;";
        }

        public void Guardar(AutoF1 autof1)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    string sentencia = "INSERT INTO RESULTADOS (escuderia, posicion, horaLlegada) VALUES (@escuderia, @posicion, @horaLlegada)";

                    SqlCommand cmd = new SqlCommand(sentencia, connection);
                    cmd.Parameters.AddWithValue("escuderia", autof1.Escuderia);
                    cmd.Parameters.AddWithValue("posicion", autof1.Posicion);
                    cmd.Parameters.AddWithValue("horaLlegada", DateTime.Now.ToString());
                    connection.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Error al guardar el Auto F1");
            }

        }
    }
}
