using System;

namespace sinalCores
{
    class Program
    {
        static void Main(string[] args)
        {
            string cor;
            Console.WriteLine("Informe a cor do semáforo:");
            cor = Console.ReadLine();
            switch(cor)
            {
                case("verde"):
                    Console.WriteLine("Siga em frente!");
                    break;
                case("amarelo"):
                    Console.WriteLine("Atenção!");
                    break;
                case("vermelho"):
                    Console.WriteLine("Pare!");
                    break;
                default:
                    Console.WriteLine("Cor inválida");
                    break;
            }
        }
    }
}
