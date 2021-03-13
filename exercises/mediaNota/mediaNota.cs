using System;

namespace mediaNota
{
    class program  
    {
        static void Main(string[] args)
        {
            string nome;
            float media,nota1,nota2,nota3,nota4;
            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Informe a primeira nota:");
            nota1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota");
            nota2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a terceira nota:");
            nota3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quarta nota:");
            nota4 = float.Parse(Console.ReadLine());
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine(nome+", sua média é:{0}",media);      
        }
    }
        
}
