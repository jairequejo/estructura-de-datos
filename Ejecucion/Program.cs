using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using System.Threading.Tasks;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazadaSimple<int> lista = new ListaEnlazadaSimple<int>();
            lista.Insertar(10);
            lista.Insertar(20);
            lista.Insertar(3);

            lista.Recorrer();
            lista.Buscar(3);
        }
    }
}
