using System;
using System.Collections;
using System.Collections.Generic;

namespace Clases.Pilas
{
    public class Pila<T> : IEnumerable<T>
    {
        public NodoPila<T> Cima { get; set; }
        public int Count { get; private set; }

        public Pila()
        {
            Cima = null;
            Count = 0;
        }

        public void Apilar(T dato)
        {
            NodoPila<T> nuevoElemento = new NodoPila<T>(dato);
            nuevoElemento.Siguiente = Cima;
            Cima = nuevoElemento;
            Count++;
        }

        public T Desapilar()
        {
            if (Cima == null)
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
            T dato = Cima.Dato;
            Cima = Cima.Siguiente;
            Count--;
            return dato;
        }

        public T VerCima()
        {
            if (Cima == null)
            {
                throw new InvalidOperationException("La pila está vacía.");
            }
            return Cima.Dato;
        }

        public bool EstaVacia()
        {
            return Cima == null;
        }

        // Implementación de IEnumerable<T> para usar 'foreach'
        public IEnumerator<T> GetEnumerator()
        {
            NodoPila<T> actual = Cima;
            while (actual != null)
            {
                yield return actual.Dato;
                actual = actual.Siguiente;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}