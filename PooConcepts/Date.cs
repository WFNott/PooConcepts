using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooConcepts
{
    // Creo la clase y le doy sus atributos

    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        /*Constructor, Inicializa la clase y crea un objeto en este caso
        llamado "Date" */

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMont(month);
            _day = CheckDay(year, month, day);
        }

        // Se crea un metodo para validar el dia segun el mes
        private int CheckDay(int year, int month, int day)
        {
            // se crea un metodo para validar si un año es bisiesto
            if (day == 29 && month == 2 && IsLeapYear(year))
            {
                return day;
            }


            /* se crea un arreglo que contiene los dias segun el mes, la posicion del arreglo inicia
            en 0, por eso el primer valor del arreglo es 0 */

            int[] DayPermMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            /* el arreglo pasa por un if que valida si el dia menor o igual a los dias que le 
             * corresponde segun el mes, por eso el arreglo se recorre segun el numero que se 
             * digite como mes*/

            if (day >= 1 && day <= DayPermMonth[month])
            {
                return day;
            }

            // se crea un nueva exception para el dia

            throw new DayException("Day Invalid");

        }

        /* Se hace un metodo bool para que cada que sea un año bisiesto me arruje true o false
         en caso de no serlo*/

        private bool IsLeapYear(int year)
        {

            /* Matematicamente un año bisiesto es multiplo de 4, pero cada 100 años no es bisiesto
             * sino cada 400 años, por lo que este mismo tambien es multiplo de 400*/

            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;


        }

        // Metodo para restringir el rango de numeros que se puede colocar en el mes

        private int CheckMont(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            /* Se crea una excepción "MonthException" esta guarda una cadena de texto como 
               argumento, se usa el "Ctrl ." para crear una clase llamada MonthException
               y asi pueda funcionar */

            throw new MonthException("Invalid Month");
        }

        // Me Muestra lo que esta dentro del objeto como una cadena de texto

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}