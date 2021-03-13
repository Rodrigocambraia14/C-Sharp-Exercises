using System;

namespace Laço_salario__posTeste_
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, soma=0, media;
            int cont=0;
            do{
                 Console.WriteLine("Informe o salário:");
                 salario = float.Parse(Console.ReadLine());
                 soma = soma + salario;
                 cont++; // cont++ equivale à "cont = cont + 1".
            }while(cont < 5);
            media = soma / cont;
            Console.WriteLine("A media salarial é:{0:N}", media);
        }
    }
}
