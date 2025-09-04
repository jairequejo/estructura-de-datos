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
    }
}
