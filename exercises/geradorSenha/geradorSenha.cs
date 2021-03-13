using System;

namespace geradorSenha
{
    class Program
    {
        static void Main(string[] args)
        {
             byte resp; //'resp' é a variável utilizada ao fim do programa
             string nome;
             ushort dia,mes,ano;
             int idade,anoAtual,mesAtual,diaAtual;
             diaAtual = DateTime.Now.Day;  //datetime para manter a data atual atualizada 
             mesAtual = DateTime.Now.Month;
             anoAtual = DateTime.Now.Year;
             Console.WriteLine("Olá! Sou seu gerador de senhas, para começar preciso de alguns dados:");
             Console.WriteLine("Qual o seu nome?");
             nome = Console.ReadLine();
             Console.WriteLine(nome+", em que dia você nasceu?");
             dia = ushort.Parse(Console.ReadLine());
             if(dia>0 && dia<=31) // validação do dia
             {
                Console.WriteLine("E em que mês você nasceu?");
                mes = ushort.Parse(Console.ReadLine());
                if(mes>0 && mes<=12)  //validação do mês
                {
                    Console.WriteLine("Para finalizar, em que ano você nasceu?");
                    ano = ushort.Parse(Console.ReadLine());
                    if(ano > 0) // validação do ano
                    {
                        Console.WriteLine("Confirmando dados, por favor aguarde.");
                        Console.WriteLine("...");
                        Console.WriteLine("Seu nome é:"+nome);
                        Console.WriteLine("Sua data de nascimento é:{0}/{1}/{2}",dia,mes,ano);
                        if(mesAtual < mes)
                        {
                            idade = (anoAtual - ano) - 1; //idade coerente com o mês de nasc. 
                        }
                        else
                        {
                            idade = anoAtual - ano; //idade coerente com o mês de nasc.
                        }
                        Console.WriteLine("Sua idade é:{0} anos",idade);
                        Console.WriteLine("Agora vamos criar sua senha!");
                        if(idade >= 18)
                        {
                            Console.WriteLine("Processando informações...");
                            Console.WriteLine("Gerando senha...");
                            Console.WriteLine("Senha gerada! sua senha é: "+idade+nome);
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("Digite [1] para visualizar a senha novamente");
                            Console.WriteLine("Digite [2] para finalizar o programa.");
                            resp = byte.Parse(Console.ReadLine());
                            if(resp == 1)
                            {
                                Console.WriteLine("Sua senha é: "+idade+nome);
                                Console.WriteLine("Encerrando o programa...");
                            }
                            else
                            {
                                Console.WriteLine("Encerrando o programa...");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Processando informações...");
                            Console.WriteLine("Gerando senha...");
                            Console.WriteLine("Senha gerada! Sua senha é: "+nome+idade);
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("Digite [1] para visualizar a senha novamente");
                            Console.WriteLine("Digite [2] para finalizar o programa.");
                            resp = byte.Parse(Console.ReadLine());
                            if(resp == 1)
                            {
                                Console.WriteLine("Sua senha é: "+nome+idade);
                                Console.WriteLine("Encerrando o programa...");
                            }
                            else
                            {
                                Console.WriteLine("Encerrando o programa...");
                            }
                            
                        }                                                                                      
                    }
                    else
                    {
                        Console.WriteLine("Insira um valor válido");
                    }
                }
                else
                {
                    Console.WriteLine("Insira um valor válido!");
                }  
             }
             else
             {
                 Console.WriteLine("Insira um valor válido!");
             }

              
        }
    }
}
