using System;

namespace ConsoleApp2ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("ingrese el numero");
            numero=int.Parse(Console.ReadLine());
            if (numero % 2 == 0)
                Console.WriteLine($"{numero} es par");
            else
                Console.WriteLine($"{numero} es impar");
            Console.ReadLine();
        }
    }
}
