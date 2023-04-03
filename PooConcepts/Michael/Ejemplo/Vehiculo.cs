using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooConcepts.Ejemplo
{
    public class Vehiculo
    {
        public int Puestos { get; set; }

        private List<Persona> _ocupantes;

        public Vehiculo(int puesto)
        {
            this.Puestos = puesto;
            this._ocupantes= new List<Persona>();
        }

        public void OcuparPuestos(List<Persona> ocupantes)
        {
            if ((this._ocupantes.Count() + ocupantes.Count()) > this.Puestos)
            {
                Console.WriteLine("Se excedio el límite de puestos.");
                return;
            }

            this._ocupantes.AddRange(ocupantes);
        }

        public void OcuparPuesto(Persona ocupante)
        {
            if ((this._ocupantes.Count() + 1) > this.Puestos)
            {
                Console.WriteLine("Se excedio el límite de puestos.");
                return;
            }

            this._ocupantes.Add(ocupante);
        }

        public void MostrarOcupantes()
        {
            foreach (var item in this._ocupantes)
            {
                Console.WriteLine($"{item.Nombre} {item.Apellido}");
            }
        }
    }
}
