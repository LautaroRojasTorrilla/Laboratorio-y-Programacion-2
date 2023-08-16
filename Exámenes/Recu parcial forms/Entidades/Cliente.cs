using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int dni;
        private List<Comida> menu;

        #region CONSTRUCTORES
        private Cliente(int dni)
        {
            this.dni = dni;
        }
        #endregion

        #region PROPIEDADES
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
        #endregion

        #region MÉTODOS
        public Comida BuscarComida(Comida comida)
        {
            foreach(Comida item in this.menu)
            {
                if (item.Equals(comida))
                {
                    return item;
                }
            }
            return null;
        }
        public static Cliente GetCliente(int dni)
        {
            return new Cliente(dni);
        }
        public static string ImprimirTicket(Cliente cliente)
        {
            if(cliente is not null)
            {
                StringBuilder datos = new StringBuilder();
                datos.AppendLine($"Dni: {cliente.dni}\nMenú:");
                foreach (Comida comida in cliente.menu)
                {
                    datos.AppendLine($"{comida.Descripcion}");
                }
                datos.AppendLine($"Total a pagar: {cliente.TotalAPagar}");
                return datos.ToString();
            }
            return "";
        }
        public static implicit operator Cliente(int dni)
        {
            return new Cliente(dni);
        }
        public static bool operator == (Cliente cliente, Comida comida)
        {
            return cliente.menu.Contains(comida);
        }
        public static bool operator !=(Cliente cliente, Comida comida)
        {
            return !(cliente == comida);
        }
        public static Cliente operator +(Cliente cliente, Comida comida)
        {
            if(cliente is not null && cliente.menu is not null)
            {
                cliente.menu.Add(comida);
                return cliente;
            }
            return null;
        }
        #endregion
    }
}
