using System;

namespace habilitação
{
    class Program
    {
        static void Main(string[] args)
        {
            byte idade;
            Console.WriteLine("Qual a sua idade?");
            idade = byte.Parse(Console.ReadLine());
            if(idade >= 18)
            {
                Console.WriteLine("Parabéns! Você já pode obter sua CNH!");
            }
            else
            {
                Console.WriteLine("Que pena! Você ainda não pode obter sua CNH!");
            }
        }
    }
}
