// See https://aka.ms/new-console-template for more information


/* se usa el using para agregar librerias o en este caso el proyecto, mismo donde esta alojado
 nuestra clase DATE y otras mas que usaremos */

using PooConcepts;
Console.WriteLine("POO Concepts");
Console.WriteLine("=============");

string.Format("Michael es {0} y además, es {1}", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"), "Ingeniero");

// Se hace un try cash para en caso de falla enviar un mensaje al usuario
try
{
    Console.WriteLine(new Date(2024, 2, 29));
    Console.WriteLine(new Date(2025, 10, 11));
    Console.WriteLine(new Date(2022, 11, 30));
}

/* Se usa el "Exception" el cual se heredo de "MonthException" y que contiene el mensaje
   de error para el usuario, estos valores se pasan a la variable "error" y luego se imprime 
   en pantalla*/

catch (Exception error)
{
    Console.WriteLine(error.InnerException != null ? error.InnerException.Message : error.Message);
}
