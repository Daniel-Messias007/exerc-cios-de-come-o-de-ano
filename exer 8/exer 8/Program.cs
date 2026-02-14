using System;

class Program
{
    static void Main()
    {
        string Cargo;
        double Percentual, Salario;
        int Codigo;
        double Aumento;
        double NovoSalario;

        Console.Write("Digite o salário atual do funcionário: R$ ");
        Salario = double.Parse(Console.ReadLine());

        Console.Write("Digite o código do cargo (101 a 104): ");
        Codigo = int.Parse(Console.ReadLine());

        

        switch (Codigo)
        {
            case 101:
                Cargo = "Administrador";
                Percentual = 0.80 / 100;
                break;

            case 102:
                Cargo = "Engenheiro";
                Percentual = 0.65 / 100;
                break;

            case 103:
                Cargo = "Médico";
                Percentual = 0.60 / 100;
                break;

            case 104:
                Cargo = "Outro cargo";
                Percentual = 0.55 / 100;
                break;

            default:
                Cargo = "Código inválido";
                Percentual = 0;
                break;
        }

        Aumento = Salario * Percentual;
        NovoSalario = Salario + Aumento;

        Console.WriteLine("Resultado:");
        Console.WriteLine("Cargo: " + Cargo);
        Console.WriteLine("Salário antigo: R$ " + Salario);
        Console.WriteLine("Ñovo Salário: R$ " + NovoSalario);
        Console.WriteLine("Diferença entre os dois salários: R$ " + Aumento);
    }
}
