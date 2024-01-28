using System.Globalization;

namespace Banco
{
    internal class Conta
    {
        public string NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(string numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Titular}, Saldo: ${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
        }

        public void Saque(double saque)
        {
            Saldo = Saldo - saque - 5;
        }
    }
}
