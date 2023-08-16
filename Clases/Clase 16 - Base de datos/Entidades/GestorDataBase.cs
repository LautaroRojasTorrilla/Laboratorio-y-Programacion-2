using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public class GestorDataBase
    {
        static string stringConnection = "Server=.;Database=Clase 15;Trusted_Connection=True;";

        public static List<Empleado> GetEmpleados()
        {
            //podrái estar adentro del using
            List<Empleado> empleados = new List<Empleado>();

            //es el objeto que va a trabar con al conexión
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                //en la sentencia es lo que vamos a hacer
                string sentencia = "SELECT * FROM EMPLEADOS";
                //le paso al sentencia y la conexión. Es el más fácil.
                SqlCommand cmd = new SqlCommand(sentencia, connection);
                //tenemos que abrir la conexion.
                connection.Open();
                //Creamos un objeto de data readery le guardamos lo que devuelve.
                //Seimpre vamos a usar para lectura
                SqlDataReader reader = cmd.ExecuteReader();
                //Este lo usamos para insert, delete, update. Las que no sean de lectura
                //cmd.ExecuteNonQuery();

                //devuelve un bool si es que hay elementos en la bdc.
                while (reader.Read())
                {
                    //Hay que ir agregándole una instancia de empleado
                    //se genera a través d elos datos que vamos recuperando de read()
                    //reader tiene un indexador
                    empleados.Add(new Empleado(reader.GetInt32(0),
                        reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                }
                //no va por afuera porque siempre está entrando al using.
                return empleados;
            }
        }

        public static Empleado GetEmpleado(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string sentencia = "SELECT * FROM EMPLEADOS WHERE ID = @id";

                SqlCommand cmd = new SqlCommand(sentencia, connection);
                //estoy bindeando el ID con un string.
                //para más parámetro hago otros addwithvalue
                cmd.Parameters.AddWithValue("id", id);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return new Empleado(reader.GetInt32(0),
                        reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                }
                throw new Exception("No existe el empleado con el ID");
            }
        }

        public static int InsertEmpleado(Empleado empleado)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))
            {
                string sentencia = "INSERT INTO EMPLEADOS (NOMBRE, APELLIDO, ID_SECTOR) VALUES (@nombre, @apellido, @idSector)";

                SqlCommand cmd = new SqlCommand(sentencia, connection);
                cmd.Parameters.AddWithValue("nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("idSector", empleado.IdSector);
                connection.Open();
                //devuelve un int con la cantidad de filas afectadas.

                return cmd.ExecuteNonQuery();
            }

        }
    }
}