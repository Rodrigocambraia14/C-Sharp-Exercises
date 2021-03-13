using System;

namespace tresInteiros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1,num2,num3;
            Console.WriteLine("Insira o primeiro número");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o terceiro número");
            num3 = int.Parse(Console.ReadLine());
            if((num1 >0 ) && (num2 > 0) && (num3 > 0))
            {   
                if((num1 != num2) && (num1 != num3) && (num2 != num3)) 
                {    
                    if((num1 > num2) && (num2 >num3))
                    {
                      Console.WriteLine(num3+","+num2+","+num1);
                    }
                    else
                    {
                        if((num3 > num2) && (num2 > num1))
                        {
                            Console.WriteLine(num1+","+num2+","+num3);
                        }
                        else
                        {
                            if((num2 > num1) && (num1 > num3))
                            {
                                Console.WriteLine(num3+","+num1+","+num2);
                            }
                            else
                            {
                                if((num2 > num3) && (num3 > num1))
                                {
                                    Console.WriteLine(num1+","+num3+","+num2);
                                }
                                else
                                {
                                    if((num3 > num1) && (num1 > num2))
                                    {
                                        Console.WriteLine(num2+","+num1+","+num3);
                                    }
                                    else
                                    {
                                        if((num1 > num3) && (num3 > num2))
                                        {
                                            Console.WriteLine(num2+","+num3+","+num1);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Os números devem ser diferentes!");
                }
            }
            else
            {
                Console.WriteLine("Os números devem ser inteiros e positivos");
            }
        }
    }
}   