using System;

class Program
{
    static void Main()
    {
        int n;
        int par = 0;
        int impar = 0;
        int positivo = 0;
        int negativo = 0;
        string respostausuario;

           Console.WriteLine("Digite um número para que o programa possa descobrir quantos números pares, impares, negativos ou positivos você digitou.");
        do
        {
            Console.WriteLine("Digite um número:");
            n = int.Parse(Console.ReadLine());

            
            if (n % 2 == 0)
                par++;
            else
                impar++;

            
            if (n > 0)
                positivo++;
            else if (n < 0)
                negativo++;

            Console.Write("Deseja encerrar o programa? (S para sim ou N para não): ");
            respostausuario = Console.ReadLine().ToUpper();

        } while (respostausuario != "S");

        Console.WriteLine("\nResultado:");
        Console.WriteLine("Quantidade de números pares: " + par);
        Console.WriteLine("Quantidade de números ímpares: " + impar);
        Console.WriteLine("Quantidade de números positivos: " + positivo);
        Console.WriteLine("Quantidade de números negativos: " + negativo);
    }
}