using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaEnlazadaCircular<T>
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
                nodoUltimo.siguiente = nodoPrimero; // Apunta al primero para hacerla circular
            }
            else
            {
                nodoUltimo.siguiente = nodoNuevo;
                nodoUltimo = nodoNuevo;
                nodoUltimo.siguiente = nodoPrimero; // Apunta al primero para hacerla circular
            }
        }
        public void Mostrar()
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
        public void Eliminar(T dato)
        {
            if (nodoPrimero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            Nodo<T> nodoActual = nodoPrimero;
            Nodo<T> nodoAnterior = null;
            do
            {
                if (Convert.ToString(nodoActual.dato) == Convert.ToString(dato))
                {
                    if (nodoAnterior != null)
                    {
                        nodoAnterior.siguiente = nodoActual.siguiente;
                        if (nodoActual == nodoUltimo) // Si es el último nodo, actualizar nodoUltimo
                        {
                            nodoUltimo = nodoAnterior;
                        }
                    }
                    else // Si es el primer nodo
                    {
                        if (nodoActual == nodoUltimo) // Si es el único nodo en la lista
                        {
                            nodoPrimero = null;
                            nodoUltimo = null;
                        }
                        else
                        {
                            nodoPrimero = nodoPrimero.siguiente;
                            nodoUltimo.siguiente = nodoPrimero; // Mantener la circularidad
                        }
                    }
                    return; // Nodo eliminado, salir del método
                }
                nodoAnterior = nodoActual;
                nodoActual = nodoActual.siguiente;
            } while (nodoActual != nodoPrimero);
        }
    }
}
