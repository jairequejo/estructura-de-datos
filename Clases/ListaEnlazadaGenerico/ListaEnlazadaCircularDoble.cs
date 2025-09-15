using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaEnlazadaCircularDoble<T>
    {
        public Nodo<T> nodoPrimero { get; set; }
        public Nodo<T> nodoUltimo { get; set; }
        public void Insertar(T dato)
        {
            Nodo<T> nodoNuevo = new Nodo<T>(dato);
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
            Nodo<T> nodoTemporal = nodoPrimero;
            do
            {
                Console.WriteLine(nodoTemporal.dato);
                nodoTemporal = nodoTemporal.siguiente;
            } while (nodoTemporal != nodoPrimero);
        }
        public void Mostrar_Atras()
        {
            if (nodoUltimo == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            Nodo<T> nodoTemporal = nodoUltimo;
            do
            {
                Console.WriteLine(nodoTemporal.dato);
                nodoTemporal = nodoTemporal.anterior;
            } while (nodoTemporal != nodoUltimo);
        }
        public void Eliminar(T dato)
        {
            if (nodoPrimero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            Nodo<T> nodoActual = nodoPrimero;
            Nodo<T> nodoAnterior = nodoUltimo;
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
