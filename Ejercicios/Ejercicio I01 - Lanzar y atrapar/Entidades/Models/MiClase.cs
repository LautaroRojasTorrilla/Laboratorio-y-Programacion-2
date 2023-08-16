using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class MiClase
    {
        public MiClase()
        {
            try
            {
                //la estyo capturando
                MetodoEstatico();
            }
            catch (Exception ex)
            {
                //relanzando, pierdo stackTrace
                throw;
            }
        }

        public MiClase(int id) //id e ssolo para la sobrecarga del constructor
        {
            try
            {
                //nunca se hace el constructor acá.
                new MiClase();
            }
            catch (Exception ex)
            {
                throw new UnaExcepcion("Este es el constructor con params de mi clase", ex);
            }
        }

        public static void MetodoEstatico ()
        {
            throw new DivideByZeroException("Este es el método estático de mi clase");
        }
    }
}
