using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chuteCerto
{
    class chuteCerto
    {
        static void Main(string[] args)
        {
            //Faça um programa que  receba um número (de 1 a 10)  digitado pelo usuário. Gere um número randomicamente. 
            //Se número  gerado  for  igual  ao  número  informado  pelo usuário, dê os parabéns e some 1 ponto.
            //Senão, some 1 ponto para o computador. Exiba o placar a cada jogada. Para sair peça que ele digite 0. 
            //ok, certo!


            int computador = 0, jogador = 0;
            Random gerador = new Random();
            int num;
            do
            {
                Console.WriteLine("Digite um número de 1 a 10:\r\n Para sair digite 0");
                num = int.Parse(Console.ReadLine());
                int n1 = gerador.Next(10);
                if (n1 == 0)
                {
                    Environment.Exit(0);
                }
                else if (num == n1)
                {
                    jogador++;
                    Console.WriteLine("Parabéns!!\r\nO número gerado é " + n1 + "\r\n Computador- " + computador + "\r\n Jogador- " + jogador);
                }
                else
                {
                    computador++;
                    Console.WriteLine("Errou!!\r\nO número gerado é " + n1 + "\r\n Computador- " + computador + "\r\n Jogador- " + jogador);
                }
            } while (num != 0);
            Console.ReadKey();
             

        }
    }
}
