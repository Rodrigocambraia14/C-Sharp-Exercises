using System;

namespace passagemOnibus
{
    class Program
    {
        static void Main(string[] args)
        {
            float passagem;
            Console.Write("Quanto você tem para a passagem? R$");
            passagem = float.Parse(Console.ReadLine());
            if (passagem < 10.00f)
            {
               Console.WriteLine("Vá de ônibus."); 
            }
            else
            {
                if((passagem < 50.00f) && (passagem >= 10f))
                {
                    Console.WriteLine("Vá de táxi.");
                }
                else
                {
                    if((passagem < 150.00f) && (passagem >= 50.00f))
                    {
                        Console.WriteLine("Vá de avião.");
                    }
                    else
                    {
                        if((passagem < 500.00f) && (passagem >= 150.00f))
                        {
                            Console.WriteLine("Vá de helicóptero");
                        }
                        else
                        {
                            if(passagem >= 500)
                            {
                                Console.WriteLine("Vá de navio.");
                            }
                        }
                    }
                }
            }
        }
    }
}
