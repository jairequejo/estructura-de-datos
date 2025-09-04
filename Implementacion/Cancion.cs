using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion
{
    public class Cancion
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }

        public Cancion(int codigo, string nombre, string genero)
        {
            Codigo = codigo;
            Nombre = nombre;
            Genero = genero;
        }

        public override string ToString() // Formatear cada objeto de la clase
        {
            return $"Cogigo: {Codigo}\n Nombre: {Nombre} \n Genero: {Genero}";
        }

        //Eliminar Cancion por su codigo
        public override bool Equals(object obj)
        {
            if (obj is Cancion)
            {
                Cancion otraCancion = (Cancion)obj;
                return this.Codigo == otraCancion.Codigo;
            }
            return false;
        }
    }
}
