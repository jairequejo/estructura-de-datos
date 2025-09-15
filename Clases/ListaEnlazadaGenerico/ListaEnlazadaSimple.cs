using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    /// <summary>
    /// Se define la clase lista enlazada simple con un parametro generico T
    /// Para definir el tipo de dato que va a almacenar la lista al instanciarla
    public class ListaEnlazadaSimple<T>
    {
        public Nodo<T> PrimerNodo { get; set; }

        public void Insertar(T dato)
        {
           Nodo<T> nuevoNodo = new Nodo<T>(dato);
              if (PrimerNodo == null)
              {
                PrimerNodo = nuevoNodo;
              }
              else
              {
                Nodo<T> nodoTemporal = PrimerNodo;
                while (nodoTemporal.siguiente != null)
                {
                     nodoTemporal = nodoTemporal.siguiente;
                }
                nodoTemporal.siguiente = nuevoNodo;
            }
        }
        public void Recorrer()
        {
            if (PrimerNodo == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            else
            {
                Nodo<T> nodoTemporal = PrimerNodo;
                while (nodoTemporal != null)
                {
                    Console.Write($"{nodoTemporal.dato} ->");
                    nodoTemporal = nodoTemporal.siguiente;
                }
            }
            Console.WriteLine(" ");
        }
        // Reemplaza la línea problemática en el método Buscar por la comparación correcta usando .Equals
        public void Buscar(T dato)
        {
            Console.WriteLine();
            if (PrimerNodo == null)
            {
                Console.WriteLine("La lista está vacía.");
            }
            else
            {
                Nodo<T> nodoTemporal = PrimerNodo;
                while (nodoTemporal != null)
                {
                    if (Convert.ToString(nodoTemporal.dato) == Convert.ToString(dato))
                    {
                        Console.WriteLine($"El dato {dato} fue encontrado en la lista.");
                        break;
                    }
                    nodoTemporal = nodoTemporal.siguiente;
                }
            }
        }
        public void Eliminar(T dato)
        {
            Nodo<T> nodoTemporal = PrimerNodo;
            Nodo<T> nodoAnterior = null;

            while(nodoTemporal != null)
            {
                if (nodoTemporal.dato.Equals(dato))
                {
                    if(nodoAnterior == null)
                    {
                        PrimerNodo = nodoTemporal.siguiente;
                    }
                    else
                    {
                        nodoAnterior.siguiente = nodoTemporal.siguiente;
                    }
                    break;
                }
                nodoAnterior = nodoTemporal;
                nodoTemporal = nodoTemporal.siguiente;
            }
        }

        //public void Ordenar()
        //{
        //    Nodo<T> nodoTemporal = PrimerNodo;
        //    while (nodoTemporal != null)
        //    {
        //        Nodo<T> nodoTemporal2 = PrimerNodo;
        //        while (nodoTemporal2 != null)
        //        {
        //            for(int i = 0;i < Convert.ToString(nodoTemporal.Dato).Length && i < Convert.ToString(nodoTemporal2.Dato).Length; i++)
        //            {
        //                if(Convert.ToString(nodoTemporal.Dato)[i] < Convert.ToString(nodoTemporal2.Dato)[i])
        //                {
        //                    T auxiliar = nodoTemporal.Dato;
        //                    nodoTemporal.Dato = nodoTemporal2.Dato;
        //                    nodoTemporal2.Dato = auxiliar;
        //                    break;
        //                }
        //                else if (Convert.ToString(nodoTemporal.Dato)[i] > Convert.ToString(nodoTemporal2.Dato)[i])
        //                {
        //                    break;
        //                }
        //            }
        //        }
        //        nodoTemporal = nodoTemporal.SiguienteNodo;
        //    }
        //    Recorrer();
        //}

        //Ordenar una lista enlazada simple de enteros y cadenas
        public void Ordenar()
        {
            bool intercambiado;
            do
            {
                intercambiado = false;
                Nodo<T> nodoTemporal = PrimerNodo;
                while (nodoTemporal.siguiente != null)
                {
                    int comparacion = Comparer<T>.Default.Compare(nodoTemporal.dato, nodoTemporal.siguiente.dato);
                    Console.WriteLine(comparacion);
                    // Si es mayor: comparacion es 1
                    // Si es igual: comparacion es 0
                    // Si es menor: comparacion es -1
                    if (comparacion > 0)
                    {
                        // Intercambiar los datos
                        T auxiliar = nodoTemporal.dato;
                        nodoTemporal.dato = nodoTemporal.siguiente.dato;
                        nodoTemporal.siguiente.dato = auxiliar;
                        intercambiado = true;
                    }
                    nodoTemporal = nodoTemporal.siguiente;
                }
            } while (intercambiado);
            Recorrer();
        }
    }
}
