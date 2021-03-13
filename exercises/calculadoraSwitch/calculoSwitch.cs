using System;

namespace calculadoraSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1,num2,resultado;
            int op;
            Console.WriteLine("Informe o primeiro número:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação desejada: [1]Adição [2]Subtração [3]Divisão [4]Multiplicação");
            op = int.Parse(Console.ReadLine());
            switch(op)
            {
                case(1):
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado é:{0:N}",resultado);
                    break;
                case(2):
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado é:{0:N}",resultado);
                    break;
                case(3):
                    resultado = num1 / num2;
                    Console.WriteLine("O resultado é:{0:N}",resultado);
                    break;
                case(4):
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado é:{0:N}",resultado);
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;              
            }
        }
    }
}
