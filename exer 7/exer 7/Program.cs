using System;

class Program
{
    static void Main()
    {
        int Dia1, Dia2, Mes1, Mes2;
        string Nome1, Nome2;


        Console.WriteLine("Digite o nome do primeiro usuário.");
        Nome1 = Console.ReadLine();

        Console.WriteLine("Digite o dia do aniversário do primeiro usuário.");
        Dia1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o mês (em número) do aniversário do primeiro usuário.");
        Mes1 = int.Parse(Console.ReadLine());


        Console.WriteLine("\nDigite o nome do segundo usuário.");
        Nome2 = Console.ReadLine();

        Console.WriteLine("Digite o dia do aniversário do segundo usuário.");
        Dia2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o mês do aniversário (em número) do segundo usuário.");
        Mes2 = int.Parse(Console.ReadLine());

        if (Mes1 < Mes2 || (Mes1 == Mes2 && Dia1 < Dia2))
        {
            Console.WriteLine("\n" + Nome1 + " faz aniversário primeiro.");
        }
        else if (Mes2 < Mes1 || (Mes1 == Mes2 && Dia1 < Dia1))
        {
            Console.WriteLine("\n" + Nome2 + " faz aniversário primeiro.");
        }
        else
        {
            Console.WriteLine("\n" + Nome1 + " e " + Nome2 + " fazem aniversário no mesmo dia.");
        }
    }
}