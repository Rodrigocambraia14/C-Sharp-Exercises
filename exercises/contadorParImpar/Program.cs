using System;

namespace a3000num
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, contPar=0, contImpar=-1; // contImpar = -1 para não contar o '9999' como valor inserido.
            do{
                Console.WriteLine("Insira um número: [9999 encerra o programa]");
                num = int.Parse(Console.ReadLine());
                
                if ( num % 2 == 0){
                    contPar = contPar + 1;
                }
                else{
                    contImpar = contImpar +1;
                }

            }while(num != 9999);
            Console.WriteLine("Contagem finalizada!");
            Console.WriteLine("Você inseriu {0} números pares e {1} números ímpares.",contPar,contImpar);
           
        }
    }
}
