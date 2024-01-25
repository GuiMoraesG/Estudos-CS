using System;

namespace POO_Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double porcent;
            double salarioLiquido;
            Funcionario funcionario = new Funcionario();
            Console.WriteLine("Digite os dados do Funcionario: ");

            funcionario.Nome = Console.ReadLine();
            funcionario.Salario = double.Parse(Console.ReadLine());
            funcionario.Imposto = double.Parse(Console.ReadLine());

            salarioLiquido = funcionario.SalarioLiquido();
            Console.WriteLine("Funcionario: " + salarioLiquido);

            Console.WriteLine("Digite o aumento do Funcionario: ");
            porcent = double.Parse(Console.ReadLine());

            funcionario.SalarioAumento(porcent);
            Console.WriteLine("Dados atualizados: " + funcionario);
        }
    }
}
