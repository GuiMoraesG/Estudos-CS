using System;

namespace POO_Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alunos alunos = new Alunos();

            Console.WriteLine("Digite o nome do aluno e suas notas: ");
            alunos.Nome = Console.ReadLine();
            alunos.Nota1 = float.Parse(Console.ReadLine());
            alunos.Nota2 = float.Parse(Console.ReadLine());
            alunos.Nota3 = float.Parse(Console.ReadLine());

            alunos.CalcMedia();
        }
    }
}
