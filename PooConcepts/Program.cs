// See https://aka.ms/new-console-template for more information


/* se usa el using para agregar librerias o en este caso el proyecto, mismo donde esta alojado
 nuestra clase DATE y otras mas que usaremos */

using PooConcepts;
using PooConcepts.Ejemplo;
using PooConcepts.ruta;
using System.Numerics;

Console.WriteLine("POO Concepts");
Console.WriteLine("=============");

// string.Format("Michael es {0} y además, es {1}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), "Ingeniero");

// Se hace un try cash para en caso de falla enviar un mensaje al usuario
/*try

{
    // Console.WriteLine(new Date(Console.ReadLine));

    //  Console.WriteLine(new Date(2025, 10, 11));

    // Console.WriteLine(new Date(2022, 11, 31));
}

/* Se usa el "Exception" el cual se heredo de "MonthException" y que contiene el mensaje
   de error para el usuario, estos valores se pasan a la variable "error" y luego se imprime 
   en pantalla*/

/*catch (Exception error)
{
    Console.WriteLine(error.InnerException != null ? error.InnerException.Message : error.Message);
}*/

Employee Employee1 = new SalaryEmployee()
{
    Id = 1,
    FirstName = "Paola",
    LastName = "Tarazona",
    BirthDate = new Date(2004, 8, 27),
    HiringDate = new Date(2009, 10, 20),
    IsActivate = true,
    Salary = 32000.32M
};

Console.WriteLine(Employee1);

Employee Employee2 = new CommissionEmployee()
{
    Id = 1,
    FirstName = "Walther",
    LastName = "Acevedo",
    BirthDate = new Date(2004, 8, 27),
    HiringDate = new Date(2009, 10, 20),
    IsActivate = true,
    Sales = 450000000M,
    CommissionPercentaje = 0.5F
};

Console.WriteLine(Employee2);


/*
Ejemplo ejemplo1 = new Ejemplo("Michael", "Rengifo");
Ejemplo ejemplo2 = new Ejemplo();
ejemplo2.Nombre = "Michael";
ejemplo2.Apellido = "Rengifo";
Ejemplo ejemplo3 = new Ejemplo()
{
    Nombre = "Michael",
    Apellido = "Rengifo"
};

Vehiculo vehiculo = new Vehiculo(4);

Persona persona1 = new Persona("Michael", "Rengifo");
Persona persona2 = new Persona("Steven", "Acevedo");
Persona persona3 = new Persona("Paola", "Tarazona");

List<Persona> lista = new List<Persona>();
lista.Add(persona1);
lista.Add(persona2);

List<Persona> lista2 = new List<Persona>();
lista2.Add(persona3);

vehiculo.OcuparPuestos(lista);
vehiculo.OcuparPuesto(persona3);
vehiculo.MostrarOcupantes();*/