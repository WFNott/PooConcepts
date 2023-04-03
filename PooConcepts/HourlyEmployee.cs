using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooConcepts
{
    public class HourlyEmployee : Employee
    {

        public decimal HourValue { get; set; }

        public float Hours { get; set; }


        public override decimal GetValueToPay()
        {
           /* decimal salida = 0.0M;
            salida = decimal.Parse("a");
            if(!decimal.TryParse("a", out salida))
            {

            }*/

            return (decimal)Hours * HourValue;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                   $"\n\tHour Value...........: {$"{HourValue:C2}",18}" +
                   $"\n\tHours................: {$"{Hours:N2}",18}" +
                   $"\n\tValue to Pay.........: {$"{GetValueToPay():C2}",18}";

        }
    }
}
