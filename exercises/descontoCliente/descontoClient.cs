using System;

namespace descontoCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            string estado;
            float pedido,desconto=0,total;
            Console.WriteLine("Informe o estado do cliente:");
            estado = Console.ReadLine();
            Console.Write("Informe o valor do pedido:R$");
            pedido = float.Parse(Console.ReadLine());
            if(estado == "RJ")
            {
                if(pedido >= 2000)
                {
                    desconto = 30f;
                    
                }
                else
                {
                    desconto = 15f;
                }
                

            }
            total =pedido - (pedido * desconto/100);
            Console.WriteLine("Valor do pedido com desconto:R${0:N}",total);
        }
    }
}
