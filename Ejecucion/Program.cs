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
            lista.Insertar(5);
            lista.Insertar(11);
            lista.Insertar(3);

            lista.Recorrer();
            lista.Ordenar();

            ListaEnlazadaSimple<string> listaString = new ListaEnlazadaSimple<string>();
            listaString.Insertar("Pepe");
            listaString.Insertar("Juan");
            listaString.Insertar("Alonso");

            listaString.Recorrer();
            listaString.Ordenar();
        }
    }
}
