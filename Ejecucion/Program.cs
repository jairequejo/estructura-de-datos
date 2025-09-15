using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clases;
using System.Threading.Tasks;
using Implementacion;
using System.Security.Cryptography.X509Certificates;
using Clases.Pilas;

namespace Ejecucion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cancion c1 = new Cancion(1, "Dopamine", "BeatBox", "Wing", "Media/cancionWing.wav");
            //Cancion c2 = new Cancion(1, "Pajaro", "Huayno", "Pingolo Producciones", "Media/cancionPajaro.wav");
            ////ListaDobleCircular<Cancion> listaCanciones = new ListaDobleCircular<Cancion>();

            ////listaCanciones.Insertar(c1);
            ////listaCanciones.Insertar(c2);
            ////listaCanciones.Mostrar_Adelante();

            //ListaEnlazadaReproduccion listaCancionesNodos = new ListaEnlazadaReproduccion();
            //listaCancionesNodos.Insertar(c2);
            //listaCancionesNodos.Insertar(c1);
            //listaCancionesNodos.Reproducir();
            Libro l1 = new Libro("El principe", "Maquiavelo", 1800, "Bigreafia");
            Libro l2 = new Libro("Sapiens", "Yuaval", 1800, "Bigreafia");
            Libro l3 = new Libro("Arte de la guerra", "Sung Tzu", 1800, "Bigreafia");
            Pila<Libro> Libros = new Pila<Libro>();
            Libros.Apilar(l1);
            Libros.Apilar(l2);
            Libros.Apilar(l3);

            Console.WriteLine("Desapilando libros:");
            Console.WriteLine(Libros.Desapilar());




        }
    }
}
