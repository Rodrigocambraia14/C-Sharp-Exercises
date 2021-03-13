using System;

namespace mediaAprov
{
    class Program
    {
        static void Main(string[] args)
        {
            float media,frequencia;
            Console.WriteLine("Informe sua média:");
            media = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe sua frequência[%]:");
            frequencia = float.Parse(Console.ReadLine());
            if(media >=7 && frequencia >= 75)
            {
                Console.WriteLine("Parabéns! Você está aprovado!");
            }
            else
            {
                Console.WriteLine("Que pena! Você está reprovado!");
            }
        }
    }
}
