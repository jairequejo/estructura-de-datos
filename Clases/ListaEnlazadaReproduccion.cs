using Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaEnlazadaReproduccion
    {
        public NodoCancion nodoPrimero { get; set; }
        public NodoCancion nodoUltimo { get; set; }
        public void Insertar(Cancion dato)
        {
            NodoCancion nodoNuevo = new NodoCancion(dato);
            if (nodoPrimero == null)
            {
                nodoPrimero = nodoNuevo;
                nodoUltimo = nodoNuevo;
                nodoPrimero.siguiente = nodoUltimo;
                nodoPrimero.anterior = nodoUltimo;
                nodoUltimo.siguiente = nodoPrimero;
                nodoUltimo.anterior = nodoPrimero;
            }
            else
            {
                nodoUltimo.siguiente = nodoNuevo;
                nodoNuevo.anterior = nodoUltimo;
                nodoNuevo.siguiente = nodoPrimero;
                nodoPrimero.anterior = nodoNuevo;
                nodoUltimo = nodoNuevo;
            }
        }
        public void Mostrar_Adelante()
        {
            if (nodoPrimero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            NodoCancion nodoTemporal = nodoPrimero;
            do
            {
                Console.WriteLine(nodoTemporal.dato);
                
                Console.WriteLine("Presiona P para pausar y renudar, S para la siguiente canción, A para la anterior canción, X para Salir.");
                char op = Console.ReadKey().KeyChar;
                switch (op)
                {
                    case 'P':
                    case 'p':
                        Console.WriteLine("\nPausado. Presiona cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case 'S':
                    case 's':
                        // Ir a la siguiente canción
                        nodoTemporal = nodoTemporal.siguiente;
                        continue; // Saltar el avance al final del bucle
                    case 'A':
                    case 'a':
                        // Ir a la canción anterior
                        nodoTemporal = nodoTemporal.anterior;
                        continue; // Saltar el avance al final del bucle
                    case 'X':
                    case 'x':
                        Console.WriteLine("\nSaliendo de la reproducción.");
                        return; // Salir del método
                    default:
                        Console.WriteLine("\nOpción no válida. Continuando con la reproducción...");
                        break;
                }
                ReproducirSonido(Convert.ToString(nodoTemporal.dato.Enlace));
                nodoTemporal = nodoTemporal.siguiente;
            } while (nodoTemporal != nodoPrimero);
        }
        private void ReproducirSonido(string ruta)
        {
            try
            {

                using (SoundPlayer player = new SoundPlayer(ruta))
                {
                    player.Load();
                    player.PlaySync(); // Reproduce el sonido de forma síncrona
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al reproducir el sonido: " + ex.Message);
            }
        }
        public void Mostrar_Atras()
        {
            if (nodoUltimo == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            NodoCancion nodoTemporal = nodoUltimo;
            do
            {
                Console.WriteLine(nodoTemporal.dato);
                nodoTemporal = nodoTemporal.anterior;
            } while (nodoTemporal != nodoUltimo);
        }
        public void Eliminar(Cancion dato)
        {
            if (nodoPrimero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            NodoCancion nodoActual = nodoPrimero;
            NodoCancion nodoAnterior = nodoUltimo;
            do
            {
                if (Convert.ToString(nodoActual.dato) == Convert.ToString(dato))
                {
                    if (nodoActual == nodoPrimero) // Si es el primer nodo
                    {
                        nodoPrimero = nodoPrimero.siguiente;
                        nodoPrimero.anterior = nodoUltimo;
                        nodoUltimo.siguiente = nodoPrimero;
                    }
                    else if (nodoActual == nodoUltimo) // Si es el último nodo
                    {
                        nodoUltimo = nodoUltimo.anterior;
                        nodoUltimo.siguiente = nodoPrimero;
                        nodoPrimero.anterior = nodoUltimo;
                    }
                    else // Nodo en medio
                    {
                        nodoAnterior.siguiente = nodoActual.siguiente;
                        nodoActual.siguiente.anterior = nodoAnterior;
                    }
                    return; // Salir después de eliminar
                }
                nodoAnterior = nodoActual;
                nodoActual = nodoActual.siguiente;
            } while (nodoActual != nodoPrimero);
            Console.WriteLine("Elemento no encontrado.");
        }
    }
}
