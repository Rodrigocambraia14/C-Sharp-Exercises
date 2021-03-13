using System;

namespace programs
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp;
            int dia, mes, ano, respo;
            dia = DateTime.Now.Day;
            mes = DateTime.Now.Month;
            ano = DateTime.Now.Year;
            Console.WriteLine("Você quer saber a data de hoje?[S/N]");
            resp = Console.ReadLine();          
             Console.WriteLine("A data de hoje é "+dia+"/"+mes+"/"+ano);                              
        }
    }
}
