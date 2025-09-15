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
            Cancion c1 = new Cancion(1, "Dopamine", "BeatBox", "Wing", "Media/cancionWing.wav");
            Cancion c2 = new Cancion(1, "Pajaro", "Huayno", "Pingolo Producciones", "Media/cancionPajaro.wav");
            //ListaDobleCircular<Cancion> listaCanciones = new ListaDobleCircular<Cancion>();

            //listaCanciones.Insertar(c1);
            //listaCanciones.Insertar(c2);
            //listaCanciones.Mostrar_Adelante();

            ListaEnlazadaReproduccion listaCancionesNodos = new ListaEnlazadaReproduccion();
            listaCancionesNodos.Insertar(c2);
            listaCancionesNodos.Insertar(c1);
            listaCancionesNodos.Reproducir();

        }
    }
}
