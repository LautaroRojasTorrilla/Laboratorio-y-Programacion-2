using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private static Estacionamiento estacionamiento;
        private int capacidadEstacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        private Estacionamiento(int capacidadEstacionamiento, string nombre)
        {
            this.capacidadEstacionamiento = capacidadEstacionamiento;
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
        }

        public List<Vehiculo> ListadoVehiculos { get => listadoVehiculos;}
        public string Nombre { get => nombre;}

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if(Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(capacidad, nombre);
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }

            return Estacionamiento.estacionamiento;
        }

        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Retiro Estacionamiento {this.Nombre}");
            sb.AppendLine(vehiculo.ToString());
            sb.AppendLine($"Hora de salida: {vehiculo.HoraEgreso}");
            sb.AppendLine($"El cargo por estacionamiento es: {vehiculo.CostoEstadia.ToString("00.0")}");
            
            return sb.ToString();
        }

        public static bool operator==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach (Vehiculo vehiculo1 in estacionamiento.listadoVehiculos)
            {
                if (vehiculo1 == vehiculo)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static bool operator+(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento.capacidadEstacionamiento > estacionamiento.ListadoVehiculos.Count
                && estacionamiento != vehiculo)
            {
                    //lo agrego al gral.
                    Estacionamiento.estacionamiento.ListadoVehiculos.Add(vehiculo);
                    return true;
            }
            return false;
        }

        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                //porque lo tengo qe sacar del general.
                Estacionamiento.estacionamiento.listadoVehiculos.Remove(vehiculo);
                vehiculo.HoraEgreso = DateTime.Now;
                return true;
            }
            return false;
        }
    }
}
