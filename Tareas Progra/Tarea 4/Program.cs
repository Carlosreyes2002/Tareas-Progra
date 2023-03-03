namespace LeerTeclado
{
    /// <summary>
    /// Leer fatos desde el teclado
    /// <summary>
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Suma de dos numeors");
            Console.Write("Ingrese numero 1:");
            // Los datos se leen como cadena
            string dato = Console.ReadLine();
            // Convertir el numero en in.Parse
            int n1 = int.Parse(dato);

            Console.Write("Ingrese numero 2: ");
            dato = Console.ReadLine();
            int n2 =int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("El resultado es : {0}", suma);
        }
    }
}