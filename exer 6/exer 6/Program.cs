using System;

class Program
{
    static void Main()
    {
        string R;
        double Salario, E, N, excessoHoras;
        double Valor = 10;
        double valorExtra = 20;

        do
        {
            Console.Write("Digite o número de horas trabalhadas: ");
            N = Convert.ToDouble(Console.ReadLine());


            if (N > 50)
            {
                excessoHoras = N - 50;
                E = excessoHoras * valorExtra;
                Salario = (50 * Valor) + E;
            }
            else
            {
                E = 0;
                Salario = N * Valor;
            }

            Console.WriteLine("Salário total: R$ " + Salario);
            Console.WriteLine("Salário excedente: R$ " + E);

            Console.Write("Deseja encerrar o programa? (S para sim e N para não): ");
            R = Console.ReadLine().ToUpper();

        } while (R != "S");
    }
}