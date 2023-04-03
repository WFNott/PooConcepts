using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooConcepts
{
    public abstract class Employee
    {
        // Se crea las propiedades del cliente

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Date BirthDate { get; set; }

        public Date HiringDate { get; set; }    

        public bool IsActivate { get ; set; }

        // se crea el metodo GetValueToPay

        public abstract decimal GetValueToPay();  

        // se crea el sobreescrito del objeto para que muestre sus propiedades y no el objeto en si

        public override string ToString()
        {
            return $"{Id} - {FirstName} {LastName}, Birth: {BirthDate}," +
                $" Hiring: {HiringDate}, IsActive: {IsActivate}";
        }


    }
}
