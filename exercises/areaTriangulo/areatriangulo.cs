using System;
    
    namespace projeto3
    {
        class Program
        {
            static void Main(string[] args)
            {
                float a,b,h;
                Console.WriteLine("Vamos calcular o triângulo!");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Informe a altura do triângulo:");
                h = float.Parse(Console.ReadLine());
                Console.WriteLine("Informe a base do triângulo");
                b = float.Parse(Console.ReadLine());
                a = (b * h)/2;
                Console.WriteLine("A área do seu triângulo é:{0}",a);
            
            }

        }
    }
    