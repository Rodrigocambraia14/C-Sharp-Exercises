using System;

namespace conversorTemperatura
{
    class program
    {
        static void Main(string[] args)
        {
            float tc,tf;
            Console.WriteLine("Olá! Sou seu conversor de temperatura!");
            Console.WriteLine("Digite a temperatura em celsius:");
            tc = float.Parse(Console.ReadLine());
            tf = (tc * 1.8f) + 32f;
            Console.WriteLine("{0}°C em Fahrenheit é: {1}°F.",tc,tf);
            
        }
    }
}
