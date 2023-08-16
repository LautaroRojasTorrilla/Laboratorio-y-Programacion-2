using Entidades.DataBase;
using Entidades.Extension;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    //13.	Vehículo, implementará el mensaje ObtenerNuevaPalabra,
    //para ello deberá leer desde la tabla “Vehiculos” en base a un ID aleatorio(hasta 37).
    //Reutilizar código.
    //me parao sobre ILector y aprieto ctrl + . ---> implementar interfaz
    public class Vehiculo : ILector
    {

        public string ObtenerNuevaPalabra()
        {
            Random rnd = new Random();
            return DataBaseManager.GetNuevaPalabra("vehiculos", rnd.GetRandomID(38));
        }
    }
}
