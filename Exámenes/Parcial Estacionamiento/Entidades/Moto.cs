using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ETipo {Ciclomotor, Scooter, Sport};
    public sealed class Moto : Vehiculo
    {
        private ETipo tipo;
        private static double valorHora;

        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Moto.valorHora = value;
                }
            }
        }

        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }

        public override string Descripcion
        {
            get
            {
                //porque es tipo enumerado, lo tengo que pasar a string.
                return this.tipo.ToString();
            }
        }

        static Moto()
        {
            Moto.valorHora = 100;
        }

        public Moto(string patente, DateTime horaIngreso, ETipo tipo) :base (horaIngreso, patente)
        {
            this.tipo = tipo;
        }

        protected override double CargoDeEstacionamiento()
        {
            return (base.CargoDeEstacionamiento() * Moto.valorHora);
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("****MOTO*****");
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine($"Marca: {this.Descripcion}");

            return sb.ToString();
        }

        //lo hago para que agregue datos.
        public override string ToString()
        {
            return this.MostrarDatos();
        }

    }
}
