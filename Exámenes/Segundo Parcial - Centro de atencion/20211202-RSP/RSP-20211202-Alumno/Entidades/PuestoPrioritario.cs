using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
//10.PuestoPrioritario:
//  a.Implementa IAtendedor.
//  b.Por defecto un puesto prioritario será de MAX_UNIDADES con 15 propductos.
//  c.La propiedad NombrePuestoAtencion retornara "Puesto de atencion Prioritario de tipo [tipo]”
//  d.La sobrecarga del operador  ==  comparara un PuestoPrioritario con un cliente para determinar si puede ser atendido por dicho puesto.
//      Se retornará True si puesto es de tipo ANT_ESPECIAL y el cliente requiere prioridad, o si el tipo es MAX_UNIDADES y la cantidad de productos del cliente es menor a los permitidos en el puesto de atención.
//  e.AtenderClientes verificara si hay clientes en espera en la fila, en caso de no haber clientes retornar Sin Clientes.
//      De lo contrario retira el primer cliente de la Queue y verifica si este puede ser atendido de forma prioritaria.
//      En caso afirmativo retornar Cliente Atendido en… Concatenando el nombre del puesto de atención.
//      En caso negativo se lanzará una excepción ClienteNoAtendidoException. 

    public class PuestoPrioritario
    {
    }
}
