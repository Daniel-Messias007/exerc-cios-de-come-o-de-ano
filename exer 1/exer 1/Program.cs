using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            y = 211;
            x = 250;
            
            while (y <= x)
            {
                if (y % 2 == 0)
                {
                    Console.WriteLine("{0}", y);
                }
                y++;
            }
            Console.ReadKey();
        }
    }
}