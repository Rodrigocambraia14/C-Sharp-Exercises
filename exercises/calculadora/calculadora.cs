using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            float num1,num2,resultado;
            Console.WriteLine("Escolha o primeiro número:");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número:");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a operação desejada: [1]Adição [2]Subtração [3]Divisão [4]Multiplicação");
            op = int.Parse(Console.ReadLine());
            if(op == 1)
            {
                resultado = num1 + num2;
                Console.WriteLine("O resultado é {0:N}",resultado);
            }    
            else
                {
                    if(op == 2)
                    {
                        resultado = num1 - num2;
                        Console.WriteLine("O resultado é {0:N}",resultado);

                    }
                    else
                    {
                        if(op == 3)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("O resultado é {0:N}",resultado);
                        }
                        else
                        {
                            if(op == 4)
                            {
                                resultado = num1 * num2;
                                Console.WriteLine("O resultado é {0:N}",resultado);
                            }
                            else
                            {
                                Console.WriteLine("Operação inválida!");
                            }
                        }
                    } 
                }

            
            
            
               
            
        }
    }
}
