using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Centro_Atencion
{
    public class CentroDeAtencion
    {
        private int cantRacsPorSuper;
        private List<Empleado> empleados;
        private string nombre;

        public CentroDeAtencion(string nombre, int cantRacsPorSuper)
        {
            this.cantRacsPorSuper = cantRacsPorSuper;
            this.nombre = nombre;
            this.empleados = new List<Empleado>();
        }

        public List<Empleado> Empleados { get => empleados;  }
        public string Nombre { get => nombre;  }

        public static bool operator ==(CentroDeAtencion c, Empleado e)
        {
            return c.empleados.Contains(e);
        }

        public static bool operator !=(CentroDeAtencion c, Empleado e)
        {
            return !(c == e);
        }

        private bool ValidaCantidadDeRacs()
        {
            int numSupervisores = empleados.Count(emp => emp is Supervisor);
            int numRacs = empleados.Count(emp => emp is Rac);

            return numRacs > (numSupervisores * cantRacsPorSuper);
        }

        public static bool operator +(CentroDeAtencion c, Empleado e)
        {
            if(c.ValidaCantidadDeRacs())
            {
                c.Empleados.Add(e); // Agregar el empleado a la colección
                return true; 
            }
            return false;
        }
        
        public static string operator -(CentroDeAtencion c, Empleado e)
        {
            if (!(c == e))
            {
                return "Empleado no encontrado";
            }
            else
            {
                e.HoraEgreso = DateTime.Now.TimeOfDay;
                string factura = e.EmitirFactura(); // Obtener la factura emitida por el empleado

                c.Empleados.Remove(e); // Remover el empleado de la colección

                return factura; // Retornar la factura emitida por el empleado
            }
        }

        public string ImprimirNomina()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nomina de empleados:");

            foreach (Empleado empleado in empleados)
            {
                sb.AppendLine($"Legajo: {empleado.Legajo}, Nombre: {empleado.Nombre}");
            }

            return sb.ToString();
        }
    }
}
