using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[15];
            int m;

            Console.WriteLine("Digite 15 números inteiros para que o programa descubra o maior.");

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                n[i] = int.Parse(Console.ReadLine());
            }

            m = n[0];

            for (int i = 1; i < 15; i++)
            {
                if (n[i] > m)
                {
                    m = n[i];
                }
            }

            Console.WriteLine("O seu maior número é: " + m);
        }
    }
}