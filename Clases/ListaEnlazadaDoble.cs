using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using Implementacion;

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
        public void Eliminar(T dato)
        {
           if (nodoPrimero == null)
           {
               Console.WriteLine("La lista está vacía.");
               return;
           }
           else if (Convert.ToString(nodoPrimero.dato) == Convert.ToString(dato))
           {
                nodoPrimero = nodoPrimero.siguiente;
                nodoPrimero.anterior = null;
           }
           else if (Convert.ToString(nodoUltimo.dato) == Convert.ToString(dato))
           {
                nodoUltimo = nodoUltimo.anterior;
                nodoUltimo.siguiente = null;
           }
           else
           {
                Nodo<T> nodoTemporal = nodoPrimero;
                while (nodoTemporal != null)
                {
                    if (Convert.ToString(nodoTemporal.dato) == Convert.ToString(dato))
                    {
                        nodoTemporal.anterior.siguiente = nodoTemporal.siguiente;
                        nodoTemporal.siguiente.anterior = nodoTemporal.anterior;
                        break;
                    }
                    nodoTemporal = nodoTemporal.siguiente;
                }

           }
        }
    }
}
