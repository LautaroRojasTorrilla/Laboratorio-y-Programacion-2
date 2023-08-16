using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class MiExcepcion : Exception
    {
        //2:58 empieza el video
        public MiExcepcion(string? message) : base(message)
        {
        }

        public MiExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
