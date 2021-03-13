using System;

namespace PAlaço
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,num2,cont=0,razao;
           Console.WriteLine("Digite o primeiro número:");
           num = int.Parse(Console.ReadLine());
           Console.WriteLine("Digite o segundo número");
           num2 = int.Parse(Console.ReadLine());
           razao = num2 - num;
           while(cont < 10)
           {
               Console.Write(" "+num);
               num = num + razao;
               cont = cont + 1;
           }
        }
    }
}
