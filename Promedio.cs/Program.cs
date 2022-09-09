using System;

namespace Promedio.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal promedio;
            Console.Write("Ingrese nota1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese nota2: ");
            int b = Convert.ToInt32(Console.ReadLine());  
            Console.Write("Ingrese nota3: ");
            int c = Convert.ToInt32(Console.ReadLine());

            promedio = (a + b + c) / 3;

            Console.WriteLine("El primedio es: " + promedio);

            Console.ReadKey();

        }
    }
}
