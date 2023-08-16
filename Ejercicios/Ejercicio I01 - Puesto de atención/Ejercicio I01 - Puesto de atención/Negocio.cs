using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01___Puesto_de_atención
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;


        private Negocio()
        {
            this.caja = new PuestoAtencion(Epuesto.Caja1);
            this.clientes = new Queue<Cliente>();
        }

        //tengo que invocar al constructor privado, no le paso nada porque no rcibe params
        public Negocio(string nombre) :this()
        {
            this.nombre = nombre;
        }

        //propfull tab tab
        public Cliente Cliente
        {
            //devuelve el proximo a ser atendido.
            get { return clientes.Dequeue(); }
            //con operador de descarte, porque retorna un booleano el ==
            //porque devuleve algo y lo tengo que guardar en algun lado
            set { _ = this + value; }
        }

        public static bool operator==(Negocio n, Cliente c)
        {
            //no se usa contains porque utiliza el equals. Cuando se compara por instancia. Si es el mismo obj.
            //comparo por el número, criterio que se establece en clase cliente.
            foreach(Cliente cli in n.clientes)
            {
                if(c == cli)
                {
                    return true;
                }
            }
            return false;
        }
        
        public static bool operator!=(Negocio n, Cliente c)
        {
            return !(n==c);
        }

        public static bool operator+(Negocio n, Cliente c)
        {
            //utilice la validacion de antes.
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        public static bool operator~(Negocio n)
        {
            //me fijo si hay cliente en la lista
             if (n.clientes.Count > 0)
            {
                //invoco le método antender y le paso el clinete con la propiedad.
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }

        public int ClientesPendientes
        {
            //retorno la cantidad
            get { return this.clientes.Count; }
        }

    }
}
