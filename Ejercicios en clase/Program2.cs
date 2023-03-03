using System;
namespace Tarea1{
    class Program
{
    static void Main(string[] args)
    {
       
       int num1, num2, suma; 
       Console.Write("GASTOS");
       Console.Write("\nIngrese un numero: ");
       num1 = Int32.Parse(Console.ReadLine());
       Console.Write("\nIngrese el numero 2: ");  
       num2 = Int32.Parse(Console.ReadLine());
       suma = num1 + num2;
       Console.WriteLine("El Resultado es: " + suma); 
       Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
       Console.ReadKey();

    }
}
}