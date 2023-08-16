using System.Data.SqlClient;
using Entidades.Excepciones;
using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Interfaces;

namespace Entidades.DataBase
{
    public static class DataBaseManager
    {
        private static string stringConnection;
        private static SqlConnection connection;

        static DataBaseManager() 
        {
            DataBaseManager.stringConnection = "Server=.;Database=20230622SP;Trusted_Connection=True;";
        }

        public static string GetImagenComida(string tipo)
        {
            try
            {
                using(DataBaseManager.connection = new SqlConnection(DataBaseManager.stringConnection))
                {
                    string query = "SELECT * FROM comidas WHERE tipo_comida = @comida";
                    SqlCommand command = new SqlCommand(query, DataBaseManager.connection);
                    command.Parameters.AddWithValue("comida", tipo);
                    DataBaseManager.connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        return reader.GetString(2);
                    }
                    throw new ComidaInvalidaExeption("Comida inexistente");

                }
            }
            catch (Exception ex)
            {

                throw new DataBaseManagerException("Error al intentar leer de la BD", ex);
            }
        }

        public static bool GuardarTicket<T>(string nombreEmpleado, T comida) where T : IComestible, new()
        {
            try
            {
                using (DataBaseManager.connection = new SqlConnection(DataBaseManager.stringConnection))
                {
                    string query = "INSERT INTO tickets (empleado, ticket) VALUES (@empleado, @tk)";

                    SqlCommand cmd = new SqlCommand(query, DataBaseManager.connection);
                    
                    cmd.Parameters.AddWithValue("empleado", nombreEmpleado);
                    //no le puedo pasar el tostring si no lo sobrescribo
                    cmd.Parameters.AddWithValue("tk", comida.Ticket);

                    DataBaseManager.connection.Open();
                    cmd.ExecuteNonQuery();

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new DataBaseManagerException("Error al intentar guardar la comida", ex);
            }
        }
    }
}
