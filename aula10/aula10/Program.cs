using System;

namespace aula10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double circunferecia, volume;
            Circulo circulo = new Circulo();

            Console.Write("Digite o valor do raio: ");
            circulo.Raio = double.Parse(Console.ReadLine());
            circunferecia = circulo.Circunferencia();
            volume = circulo.Volume();

            Console.WriteLine("Circunferêcia: " + circunferecia.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor do PI: " + circulo.PI.ToString("F2"));

        }
    }
}
