using System;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor;

            Console.Write("Número da conta: ");
            string numeroConta = Console.ReadLine();

            Console.Write("Titular da Conta: ");
            string titular = Console.ReadLine();

            Conta conta = new Conta(numeroConta, titular);

            Console.Write("Deposito inicial (s/n): ");
            char prosseguir = char.Parse(Console.ReadLine());

            if (prosseguir == 's')
            {
                Console.WriteLine("Valor Depósito inicial: ");
                valor = double.Parse(Console.ReadLine());

                conta.Depositar(valor);
            }

            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);

            Console.WriteLine("Valor para depósito: ");
            valor = double.Parse(Console.ReadLine());
            conta.Depositar(valor);
            Console.WriteLine(conta);

            Console.WriteLine("Valor para Saque: ");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);
            Console.WriteLine(conta);
        }
    }
}
