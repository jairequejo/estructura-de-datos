using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion
{
    public class Libro
    {
        public string Titulo { get; set;}
        public string Autor {  get; set;}
        public int Ano {  get; set;}
        public string Genero { get; set;}

        public Libro(string titulo, string autor, int ano, string genero)
        {
            Titulo = titulo;
            Autor = autor;
            Ano = ano;
            Genero = genero;
        }
        public override string ToString()
        {
            return $"Titulo: {Titulo}\n Autor: {Autor} \n Año: {Ano} \n Género: {Genero}";
        }
    }
}
