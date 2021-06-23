using System;

namespace LaçoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contatos = new string[4];
            contatos[0] = "Maria Joaquina";
            contatos[1] = "Antonio Blay";
            contatos[2] = "José Almeida";
            contatos[3] = "Vitor Fuly";
            for(int i = 0; i < contatos.Length; i++)
            {
                Console.WriteLine("Contato " + (i + 1) + ": " + contatos[i]);
            }
        }
    }
}
