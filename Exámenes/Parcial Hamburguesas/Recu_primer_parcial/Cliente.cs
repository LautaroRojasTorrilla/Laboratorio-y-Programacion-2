using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recu_primer_parcial
{
    public class Cliente
    {
        private List<Comida> menu;
        private int dni;

        private Cliente(int dni) 
        { 
            this.dni = dni;
            this.menu = new List<Comida>();
        }

        private double TotalAPagar
        {
            get
            {
                double total = 0;
                foreach (Comida comida in this.menu)
                {
                    total += comida.Costo;
                }
                return total;
            }
        }

        static Cliente GetCliente(int dni)
        {
            return dni;
        }

        public static implicit operator Cliente(int dni) {  return new Cliente(dni); }

        public static Cliente operator +(Cliente cliente, Comida comida)
        {
                cliente.menu.Add(comida);
                return cliente;
        }

        public Comida BuscarComida(Comida comida)
        {
            //foreach (Comida c in menu)
            //{
            //    if (c.Equals(comida))
            //    {
            //        return c;
            //    }
            //}
            //return null;

            //resolución de Ale con Find.
            return this.menu.Find(c => c.Equals(comida));
        }

        public static string ImprimirTicket(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();

            // Datos del cliente
            sb.AppendLine($"Cliente: DNI {cliente.dni}");

            // Menú del cliente
            sb.AppendLine("Menú:");
            foreach (Comida comida in cliente.menu)
            {
                sb.AppendLine(comida.Descripcion);
            }

            // Total a pagar
            sb.AppendLine($"Total a pagar: {cliente.TotalAPagar}");

            return sb.ToString();
        }

        public static bool operator ==(Cliente cliente, Comida comida)
        {
            return cliente.menu.Contains(comida);
        }
        public static bool operator !=(Cliente cliente, Comida comida)
        {
            return !(cliente == comida);
        }

    }
}
