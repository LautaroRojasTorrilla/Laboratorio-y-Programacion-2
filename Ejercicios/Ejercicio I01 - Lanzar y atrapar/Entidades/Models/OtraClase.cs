using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class OtraClase
    {
        public void MetodoInstancia()
        {

            try
            {
                new MiClase(200);
            }
            catch (Exception ex)
            {
                throw new MiExcepcion("Esta es una excepción de OtraClase", ex);
            }
        }
    }
}
