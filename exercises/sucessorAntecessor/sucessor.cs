using System;
    namespace sucessor
    {
        class Program
        {
            static void Main(string[] args)
            {
                int numero,sucessor,antecessor;
                Console.WriteLine("Informe um número:");
                numero = int.Parse(Console.ReadLine());
                sucessor = (numero + 1);
                antecessor = (numero - 1);
                Console.WriteLine("Seu número é:{0}",numero);
                Console.WriteLine("O sucessor do seu número é :{0}",sucessor);
                Console.WriteLine("O antecessor do seu número é:{0}",antecessor);

            }
        }
    }