using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Se define la clase nodo con un parametro generico T
    /// Para definir el tipo de dato que va a almacenar el nodo
    public class Nodo<T>
    {
        public  T dato { get; set; }
        public Nodo<T> siguiente { get; set; }
        public Nodo<T> anterior { get; set; }

        public Nodo(T dato)
        {
            this.dato = dato;
            siguiente = null;
            anterior = null;
        }

    }
}
