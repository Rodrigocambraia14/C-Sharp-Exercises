using System;
    namespace idade
    {
        class Program
        {
            static void Main(string[] args)
            {
                int dia;
                int idade;
                ushort ano,anoAtual;
                Console.WriteLine("Em que ano você nasceu?");
                ano = ushort.Parse(Console.ReadLine());
                Console.WriteLine("Em que ano nós estamos?");
                anoAtual = ushort.Parse(Console.ReadLine());
                idade = (anoAtual - ano);
                dia = (idade * 365);
                Console.WriteLine("Você tem {0} anos e está vivo há {1} dias",idade,dia);
                
            }
        }
    }