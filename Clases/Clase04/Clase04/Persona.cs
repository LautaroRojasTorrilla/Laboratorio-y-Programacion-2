using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04
{
    public class Persona
    {
        private int dni;

        private static Persona persona;

        //generar conversoin implicita para construir una persona a traves del dni

        private Persona(int dni)
        {
            this.dni = dni;
        }

        //metodo estático para contruir un objeto
        public static Persona GetPersona(int dni)
        {
            //valida si existe, si está instanciado o no y lo retorna.
            if(Persona.persona is null)
            {
                Persona.persona = new Persona(dni);
            }
            return Persona.persona;
        }

        public int GetDNI()
        { 
            return dni;
        }

        //desde un entero, estoy devolviendo un objeto
        public static implicit operator Persona(int dni)
        {
            return new Persona(dni);
        }

        public static implicit operator int(Persona p)
        {
            return p.dni;
        }
    }
}
