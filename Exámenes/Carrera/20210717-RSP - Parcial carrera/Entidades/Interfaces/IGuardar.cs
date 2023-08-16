using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IGuardar <T> where T : class, new()
    {
        public void Guardar(T tipo);
    }
}
