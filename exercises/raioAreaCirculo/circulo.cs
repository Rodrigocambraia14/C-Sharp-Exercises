using System;
    namespace circulo
    {
        class Program
        {
            static void Main(string[] args)
            {
                string medida;
                double raio,area;
                Console.WriteLine("Informe a medida utilizada[mm/cm/m]");
                medida = Console.ReadLine();
                Console.WriteLine("Informe o raio do círculo");
                raio = float.Parse(Console.ReadLine());
                area = (Math.Pow(raio,2) * 3.14);
                Console.WriteLine("O círculo de raio igual à {0}{1} tem área de {2}{3}².",raio,medida,area,medida);
            }
        }
    }