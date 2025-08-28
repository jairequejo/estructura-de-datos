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
                while (nodoTemporal.SiguienteNodo != null)
                {
                     nodoTemporal = nodoTemporal.SiguienteNodo;
                }
                nodoTemporal.SiguienteNodo = nuevoNodo;
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
                    Console.Write($"{nodoTemporal.Dato} ->");
                    nodoTemporal = nodoTemporal.SiguienteNodo;
                }
            }
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
                    if (Convert.ToString(nodoTemporal.Dato) == Convert.ToString(dato))
                    {
                        Console.WriteLine($"El dato {dato} fue encontrado en la lista.");
                        break;
                    }
                    nodoTemporal = nodoTemporal.SiguienteNodo;
                }
            }
        }
        public void Eliminar(T dato)
        {
            Nodo<T> nodoTemporal = PrimerNodo;
            Nodo<T> nodoAnterior = null;

            while(nodoTemporal != null)
            {
                if (nodoTemporal.Dato.Equals(dato))
                {
                    if(nodoAnterior == null)
                    {
                        PrimerNodo = nodoTemporal.SiguienteNodo;
                    }
                    else
                    {
                        nodoAnterior.SiguienteNodo = nodoTemporal.SiguienteNodo;
                    }
                    break;
                }
                nodoAnterior = nodoTemporal;
                nodoTemporal = nodoTemporal.SiguienteNodo;
            }
        }
        public void OrdenarBubleSort()
        {
            if (PrimerNodo == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            bool swapped;
            do
            {
                swapped = false;
                Nodo<T> current = PrimerNodo;
                while (current != null && current.SiguienteNodo != null)
                {
                    // Asumiendo que T implementa IComparable para poder comparar los datos
                    if (Comparer<T>.Default.Compare(current.Dato, current.SiguienteNodo.Dato) > 0)
                    {
                        // Intercambiar los datos
                        T temp = current.Dato;
                        current.Dato = current.SiguienteNodo.Dato;
                        current.SiguienteNodo.Dato = temp;
                        swapped = true;
                    }
                    current = current.SiguienteNodo;
                }
            } while (swapped);
        }

    }
}
