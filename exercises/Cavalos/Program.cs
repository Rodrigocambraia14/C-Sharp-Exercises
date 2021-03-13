using System;

namespace Cavalos
{
    class Program
    {
        static void Main(string[] args)
        {
            string horse, horseMenor;
            float tempo, cont=0, tempoMenor;
            Console.WriteLine("Insira o nome do cavalo:");
            horse = Console.ReadLine();
            Console.WriteLine("Insira o tempo do cavalo (em segundos):");
            tempo = float.Parse(Console.ReadLine());
            tempoMenor = tempo;
            horseMenor = horse;
            while(cont < 9 )
            {

                Console.WriteLine("Insira o nome do cavalo:");
                horse = Console.ReadLine();
                Console.WriteLine("Insira o tempo do cavalo (em segundos):");
                tempo = float.Parse(Console.ReadLine());
                cont = cont + 1;
                if(tempo < tempoMenor){
                    tempoMenor = tempo;
                    horseMenor = horse;
                    Console.WriteLine("O cavalo com tempo recorde é {0} com o tempo de {1} segundos.",horseMenor,tempoMenor);
                }
            }
                
                  
        }
    }
}
