using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //12.GestorBD:
    //  a.Sera estática.
    //  b.ObtenerCliente correrá en un hilo secundario, este leerá de la base de datos todos los clientes.
    //      Mientras no sea el fin de los registros o no se haya cancelado el hilo se informará el cliente leído a través del evento.
    //  c.Realizar un Sleep de 2 segundos.
    //  d.En caso de producirse un error encapsular la excepción y lanzar BaseDeDatosException.

    public class GestorBD
    {
    }
}
