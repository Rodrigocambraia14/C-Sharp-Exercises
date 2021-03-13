using System;

namespace Automovel
{
    class Program
    {
        static void Main(string[] args)
        {
            string cor;
            int ano;
            Console.WriteLine("Informe a cor do veículo:");
            cor = Console.ReadLine();
            Console.WriteLine("Informe o ano do veículo:");
            ano = int.Parse(Console.ReadLine());
            if ((cor=="preto" || cor=="cinza") && ano>=2016)
            {
                Console.WriteLine("Seu veículo está aprovado!");       
            } 
            else
            {
                Console.WriteLine("Seu veículo não está aprovado!");
            }            
        }
    }
}
