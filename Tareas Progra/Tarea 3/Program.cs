using System;

namespace Fundamentos
{
    class EntradaSalida
    {
        public static void Main (string[] arg )
        {
            string nombre;

            Console.Write("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.Read();

        }
    }
}