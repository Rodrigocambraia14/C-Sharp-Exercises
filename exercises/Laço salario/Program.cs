using System;

namespace testeLaço
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, soma=0, media;
            int cont=0;
            while (cont < 5)
            {
                Console.WriteLine("Insira o salário:");
                salario = float.Parse(Console.ReadLine());
                soma = soma + salario;
                cont = cont + 1;
            }
            media = soma / cont;
            Console.WriteLine("O valor médio do salário é: {0:N}" ,media);

        }
    }
}
