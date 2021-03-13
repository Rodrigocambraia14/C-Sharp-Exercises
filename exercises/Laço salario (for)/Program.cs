using System;

namespace Laço_salario__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, soma=0, media;
            int cont;
            for (cont=0;cont<5;cont++)
            {
                Console.WriteLine("Informe o salario:");
                salario = float.Parse(Console.ReadLine());
                soma = soma + salario;
            }
            media = soma / cont;
            Console.WriteLine("A media salarial é:{0:N}", media);
        }
    }
}
