using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabado_22_04
{
    public class Empleado
    {
        private String _nombre;
        private float _sueldo;
        //ver como hacer
        //investigar bitmap
        private String _path_imagen;

        public Empleado(string nombre, float sueldo)
        {
            this._nombre = nombre;
            this._sueldo = sueldo;
            this._path_imagen = _path_imagen;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public float Sueldo { get => _sueldo; set => _sueldo = value; }

        public override string ToString() 
        { 
            return _nombre + " " + _sueldo;
        }
    }
}
