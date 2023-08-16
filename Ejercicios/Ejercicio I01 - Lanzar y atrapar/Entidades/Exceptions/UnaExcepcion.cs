using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class UnaExcepcion : Exception
    {
        //2:58 empieza el video

        public UnaExcepcion(string? message) : base(message)
        {
        }

        public UnaExcepcion(string? message, Exception? innerException) : base(message, innerException)
        {
        }

    }
}
