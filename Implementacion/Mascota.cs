using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacion
{
    public class Mascota
    {
        public string nombre {  get; set; }
        public string especie {get; set; }
        public string dueño { get; set; }

        public Mascota()
        {

        }
        public Mascota(string nombre, string especie, string duerño)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.dueño = duerño;
        }
        public override string ToString()
        {
            return $"[{nombre} | {especie} | {dueño}]";
        }   
    }
}
