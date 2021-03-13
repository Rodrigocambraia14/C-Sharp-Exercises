using System;

namespace altura
{
    class Program
    {
        static void Main(string[] args)
        {
            float altura;
            Console.WriteLine("Qual a sua altura?");
            altura = float.Parse(Console.ReadLine());
            if(altura >= 1.80f)
                Console.WriteLine("Alto");
            else
            {
                Console.WriteLine("Baixo");
            }
        }
    }
}
