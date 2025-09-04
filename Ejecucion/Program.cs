using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using System.Threading.Tasks;
using Implementacion;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cancion cancion01 = new Cancion(1, "Duro 2 horas.mp3", "trap");
            Cancion cancion02 = new Cancion(2, "carnavales mix.mp3", "carnavales");
            Cancion cancion03 = new Cancion(3, "Todo lo beuno tarda.mp3", "rap");
            Cancion cancion04 = new Cancion(4, "Puertas", "rock");

            ListaEnlazadaCircular<Cancion> ListaCanciones = new ListaEnlazadaCircular<Cancion>();

            ListaCanciones.Insertar(cancion01);
            ListaCanciones.Insertar(cancion02);
            ListaCanciones.Insertar(cancion03);
            ListaCanciones.Insertar(cancion04);

            ListaCanciones.Mostrar();

            //ListaCanciones.Eliminar(cancion01);

            //ListaCanciones.Mostrar();


        }
    }
}
