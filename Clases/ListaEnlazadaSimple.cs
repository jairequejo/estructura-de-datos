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
        public Nodo<T> Primero { get; set; }

        public void Insertar(T dato)
        {
           Nodo<T> nuevo = new Nodo<T>(dato);
              if (Primero == null)
              {
                Primero = nuevo;
              }
              else
              {
                Nodo<T> temporal = Primero;
                while (temporal.Enlace != null)
                {
                     temporal = temporal.Enlace;
                }
                temporal.Enlace = nuevo;
            }
        }
        public void Recorrer()
        {
            if (Primero == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }
            else
            {
                Nodo<T> temporal = Primero;
                while (temporal != null)
                {
                    Console.Write($"{temporal.Dato} ->");
                    temporal = temporal.Enlace;
                }
            }
        }
        // Reemplaza la línea problemática en el método Buscar por la comparación correcta usando .Equals
        public void Buscar(T dato)
        {
            Console.WriteLine();
            if (Primero == null)
            {
                Console.WriteLine("La lista está vacía.");
            }
            else
            {
                Nodo<T> temporal = Primero;
                while (temporal != null)
                {
                    if (Convert.ToString(temporal.Dato) == Convert.ToString(dato))
                    {
                        Console.WriteLine($"El dato {dato} fue encontrado en la lista.");
                        break;
                    }
                    temporal = temporal.Enlace;
                }
            }
        }
        public void Eliminar(T dato)
        {
            Nodo<T> temporal = Primero;
            Nodo<T> anterior = null;

            while(temporal != null)
            {
                if (temporal.Dato.Equals(dato))
                {
                    if(anterior == null)
                    {
                        Primero = temporal.Enlace;
                    }
                    else
                    {
                        anterior.Enlace = temporal.Enlace;
                    }
                    break;
                }
            }
            anterior = temporal;
            temporal = temporal.Enlace;
        }
    }
}
