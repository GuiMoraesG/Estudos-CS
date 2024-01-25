using System;

namespace POO_Exercicio04
{
    internal class Funcionario
    {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void SalarioAumento(double porcent)
        {
            Salario = Salario + (Salario * porcent / 100);
        }

        public override string ToString()
        {
            return $"{Nome}, R$ {Salario - Imposto}";
        }
    }

}
