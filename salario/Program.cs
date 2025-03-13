using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantos funcionários deseja cadastrar? ");
        int quantidade = int.Parse(Console.ReadLine());

        double[] salarios = new double[quantidade];

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Digite o salário do seu funcionário {i + 1}: R$ ");
            salarios[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nSalários reajustados:");

        for (int i = 0; i < quantidade; i++)
        {
            double aumento = salarios[i] <= 500 ? 0.10 : 0.08;
            double novoSalario = salarios[i] * (1 + aumento);
            Console.WriteLine($"Funcionário {i + 1}: R$ {novoSalario:F2}");
        }
    }
}