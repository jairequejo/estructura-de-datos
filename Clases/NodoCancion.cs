using Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class NodoCancion
    {
        public Cancion dato { get; set; }
        public NodoCancion siguiente { get; set; }
        public NodoCancion anterior { get; set; }

        public NodoCancion(Cancion dato)
        {
            this.dato = dato;
            siguiente = null;
            anterior = null;
        }
    }
}
