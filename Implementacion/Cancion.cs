using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencia  a la libreria SoundPlayer
using System.Media;
using NAudio.Dmo;


namespace Implementacion
{
    public class Cancion
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public string Artista { get; set; }
        // agregar enlace de la cancion
        public string Enlace { get; set; }
        public Cancion(int codigo, string nombre, string genero, string artista, string enlace)
        {
            Codigo = codigo;
            Nombre = nombre;
            Genero = genero;
            Artista = artista;
            Enlace = enlace;
        }

        public override string ToString() // Formatear cada objeto de la clase
        {
            return $"Cogigo: {Codigo}\n Nombre: {Nombre} \n Genero: {Genero} \n Artista: {Artista}";
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
