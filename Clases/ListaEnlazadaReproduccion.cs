using Implementacion;
using System;
using WMPLib; // Agregar referencia a Windows Media Player (COM)

namespace Clases
{
    public class ListaEnlazadaReproduccion
    {
        public NodoCancion nodoPrimero { get; set; }
        public NodoCancion nodoUltimo { get; set; }
        private WindowsMediaPlayer player; // Reproductor global

        public ListaEnlazadaReproduccion()
        {
            player = new WindowsMediaPlayer();
        }

        public void Insertar(Cancion dato)
        {
            NodoCancion nodoNuevo = new NodoCancion(dato);
            if (nodoPrimero == null)
            {
                nodoPrimero = nodoNuevo;
                nodoUltimo = nodoNuevo;
                nodoPrimero.siguiente = nodoPrimero;
                nodoPrimero.anterior = nodoPrimero;
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

        public void Reproducir()
        {
            if (nodoPrimero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            NodoCancion actual = nodoPrimero;
            bool salir = false;

            // Mostrar menú de controles
            Menu();

            // Reproducir primera canción
            ReproducirSonido(actual.dato.Enlace);
            Console.WriteLine($"> Reproduciendo: {actual.dato.Nombre}");

            while (!salir)
            {
                if (Console.KeyAvailable) // ✅ Detecta si hay tecla presionada sin bloquear
                {
                    char op = Console.ReadKey(true).KeyChar;

                    switch (char.ToLower(op))
                    {
                        case 'p':
                            if (player.playState == WMPPlayState.wmppsPlaying)
                            {
                                player.controls.pause();
                                Console.WriteLine("== Pausado ==");
                            }
                            else if (player.playState == WMPPlayState.wmppsPaused)
                            {
                                player.controls.play();
                                Console.WriteLine(">> Reanudado <<");
                            }
                            break;

                        case 's':
                            Menu();
                            actual = actual.siguiente;
                            ReproducirSonido(actual.dato.Enlace);
                            Console.WriteLine($">> Siguiente: {actual.dato.Nombre}");
                            break;

                        case 'a':
                            Menu();
                            actual = actual.anterior;
                            ReproducirSonido(actual.dato.Enlace);
                            Console.WriteLine($"<< Anterior: {actual.dato.Nombre}");
                            break;

                        case 'x':
                            Console.WriteLine("> Saliendo del reproductor...");
                            salir = true;
                            player.controls.stop();
                            break;

                        default:
                            Console.WriteLine("> Opción no válida. Usa [P], [S], [A], [X]");
                            break;
                    }
                }

                System.Threading.Thread.Sleep(200); // evita que consuma 100% CPU
            }
        }

        private void Menu()
        {
            Console.Clear();
            Console.WriteLine("\n == Reproductor Interactivo ==");
            Console.WriteLine(" [P] Pausar/Reanudar");
            Console.WriteLine(" [S] Siguiente canción");
            Console.WriteLine(" [A] Canción anterior");
            Console.WriteLine(" [X] Salir del reproductor\n");
        }


        private void ReproducirSonido(string ruta)
        {
            try
            {
                player.controls.stop();
                player.URL = ruta; // Asignar ruta de la canción
                player.controls.play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al reproducir el sonido: " + ex.Message);
            }
        }

        public void Eliminar(Cancion dato)
        {
            if (nodoPrimero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            NodoCancion actual = nodoPrimero;

            do
            {
                if (actual.dato.Equals(dato))
                {
                    if (actual == nodoPrimero && actual == nodoUltimo)
                    {
                        nodoPrimero = null;
                        nodoUltimo = null;
                    }
                    else if (actual == nodoPrimero)
                    {
                        nodoPrimero = nodoPrimero.siguiente;
                        nodoPrimero.anterior = nodoUltimo;
                        nodoUltimo.siguiente = nodoPrimero;
                    }
                    else if (actual == nodoUltimo)
                    {
                        nodoUltimo = nodoUltimo.anterior;
                        nodoUltimo.siguiente = nodoPrimero;
                        nodoPrimero.anterior = nodoUltimo;
                    }
                    else
                    {
                        actual.anterior.siguiente = actual.siguiente;
                        actual.siguiente.anterior = actual.anterior;
                    }
                    return;
                }
                actual = actual.siguiente;
            } while (actual != nodoPrimero);

            Console.WriteLine("Elemento no encontrado.");
        }
    }
}
