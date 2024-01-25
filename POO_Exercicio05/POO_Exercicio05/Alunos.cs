using System;

namespace POO_Exercicio05
{
    internal class Alunos
    {
        public string Nome;
        public float media;
        public float Nota1;
        public float Nota2;
        public float Nota3;

        public void CalcMedia()
        {
            media = (Nota1 + Nota2 + Nota3) / 3;
            Console.WriteLine("Nota Final = " + media);

            if (media > 6)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                media -= 6;
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Faltaram: " + Math.Abs(media));
            }
        }
    }
}
