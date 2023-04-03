using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooConcepts.ruta
{
    public class Ejemplo
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public Ejemplo() { }

        public Ejemplo(string nombre, string apellido) {
            this.Nombre = nombre;
            this.Apellido= apellido;
        }

        public string GetFullName()
        {
            return $"{this.Nombre} {this.Apellido}";
            //return string.Format("{0} {1}", this.Nombre, this.Apellido);
        }
    }
}
