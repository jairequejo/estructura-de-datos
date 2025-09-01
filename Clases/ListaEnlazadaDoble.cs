using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Clases
{
    public class ListaEnlazadaDoble<T>
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
            }
            else
            {
                nodoUltimo.siguiente = nodoNuevo;
                nodoNuevo.anterior = nodoUltimo;
                nodoUltimo = nodoNuevo;
            }
        }

        public void Mostrar_Adelante()
        {
            Nodo<T> nodoTemporal = nodoPrimero;
            while (nodoTemporal != null)
            {
                Console.WriteLine(nodoTemporal.dato);
                nodoTemporal = nodoTemporal.siguiente;
            }
        }
        public void Mostrar_Atras()
        {
            Nodo<T> nodoTemporal = nodoUltimo;
            while (nodoTemporal != null)
            {
                Console.WriteLine(nodoTemporal.dato);
                nodoTemporal = nodoTemporal.anterior;
            }
        }
    }
}
