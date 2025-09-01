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
            ListaEnlazadaDoble<int> lista = new ListaEnlazadaDoble<int>();
            lista.Insertar(5);
            lista.Insertar(11);
            lista.Insertar(3);
            lista.Insertar(22);
            lista.Insertar(0);



            lista.Mostrar_Adelante();
            Console.WriteLine();
            lista.Mostrar_Atras();
        }
    }
}
