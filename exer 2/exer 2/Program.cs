using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, f;

            Console.WriteLine("Digite dois números.");
            Console.WriteLine("Digite o primeiro número: ");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            f = int.Parse(Console.ReadLine());

            while (f <= i)
            {
                if (f % 2 == 1)
                {
                    Console.WriteLine("{0}", f);
                }
                f++;
            }
            Console.ReadKey();
        }
    }
}