using System;
    namespace combustivel
    {
        class Program
        {
            static void Main(string[] args)
            {
                float distancia,combustivel;
                Console.WriteLine("Digite a distância desejada[Km]:");
                distancia = float.Parse(Console.ReadLine());
                combustivel = (distancia/12);
                Console.WriteLine("Você precisa de {0:N}L de combustível para percorrer {1}Km!",combustivel,distancia);
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Para os cálculos, foram utilizados como média de consumo: 12km/L e adotamos Km como medida padrão.");
                
            }
        }
        
    }