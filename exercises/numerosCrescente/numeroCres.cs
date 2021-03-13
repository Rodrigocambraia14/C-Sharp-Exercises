using System;

namespace numerosCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numero1,numero2;
            Console.WriteLine("Escreva o 1° número positivo:");
            numero1 = uint.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o 2° número positivo:");
            numero2 = uint.Parse(Console.ReadLine());
            if(numero1 > numero2)
            {
                Console.WriteLine(numero2+","+numero1);
            }
            else
            {
                Console.WriteLine(numero1+","+numero2);
            }

        }
    }
}
