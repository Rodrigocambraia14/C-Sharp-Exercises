using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, result, i;
            
            Console.WriteLine("Olá! Insira o número no qual deseja obter o fatorial!");
            num = int.Parse(Console.ReadLine());
            Console.Write(num+"! = "+num);
            result = num;
            for(i = num - 1; i >=1 ; i--)
            {
                Console.Write(" x "+i);
                 result = result * i;
            }
            Console.WriteLine(" ");
            Console.WriteLine(" O resultado é: "+result);
           
            

        }
    }
}
