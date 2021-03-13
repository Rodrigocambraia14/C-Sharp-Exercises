using System;

namespace partidaDeFutebol
{
    class Program
    {
        static void Main(string[] args)
        {
            string time1,time2;
            byte gol1,gol2;
            Console.WriteLine("Escreva o nome do primeiro time:");
            time1 = Console.ReadLine();
            Console.WriteLine("Escreva o nome do segundo time:");
            time2 = Console.ReadLine();
            Console.WriteLine("Quantos gols o {0} fez?",time1);
            gol1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Quantos gols o {0} fez?",time2);
            gol2 = byte.Parse(Console.ReadLine());
            if(gol1 != gol2)
            {
                if(gol1 > gol2) 
                {  
                    Console.WriteLine("O time vencedor é o {0}!",time1);
                }
                else
                {
                    Console.WriteLine("O time vencedor é o {0}!",time2);
                }    
            }
            else
            {
                Console.WriteLine("Empate!");
            }            
        }
    }
}
