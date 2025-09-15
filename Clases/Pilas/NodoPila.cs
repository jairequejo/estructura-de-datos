using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Pilas
{
    public class NodoPila<T>
    {
        public T Dato { get; set; }
        public NodoPila<T> Siguiente { get; set; }

        public NodoPila(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
