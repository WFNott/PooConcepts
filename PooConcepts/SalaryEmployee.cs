using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooConcepts
{
    // se crea la clase SalaryEmployee y obtiene el acceso a los recursos de la clase Employee con " : "

    public class SalaryEmployee : Employee
    {
        // Se crea la propiedad Salary

        public decimal Salary { get; set; }

        // Se trae el metodo GetValueToPay creado anteriormente en la clase Employee

        public override decimal GetValueToPay() {


             return Salary;

        }

        /* Se sobreescribe el objeto, con la intencion de mostrar el contenido ya previamente 
        guardado en la clase Employee con "{base.ToString()}" y se agrega nueva información que
        se quiera mostrar*/

        public override string ToString()
        {
            return $"{base.ToString()}" +
                 $"\n\tValue to Pay: {GetValueToPay():C2}";
            
        }
    }
}
