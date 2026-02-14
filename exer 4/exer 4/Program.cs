using System;

class Program
{
    static void Main()
    {
        double[] notas = new double[10];
        double soma = 0;
        int contador = 0;
        double nota, media;

        Console.WriteLine("Digite 10 notas entre 0 e 10 para calcular a média delas.");

        while (contador < 10)
        {
            Console.Write( (contador + 1) + "º " + "Nota" + ": ");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 0 && nota <= 10)
            {
                notas[contador] = nota;
                soma += nota;
                contador++;
            }
            else
            {
                Console.WriteLine("NÃO, ESTÁ ERRADO! Digite uma nota entre 0 e 10!!!");
            }
        }

        media = soma / 10;

        Console.WriteLine("A média das notas é: " + media);


    }
}

