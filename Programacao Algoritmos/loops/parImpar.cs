using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parImpar
{
    class parImpar
    {
        static void Main(string[] args)
        {
            //Faça um programa que o usuário escolha entre as opções "1- par\n 2- Ímpar\n 0-Sair". Exiba um número obtido radomicamente. Se ele acertar
            //conte o ponto para o usuário, senão, ponto para o computador. eiva o placar a cada jogada. Utilize o loop while.
            //ok, certo!

            Random gerador = new Random();
            int escolha = -1;
            int computador = 0;
            int jogador = 0;
            while (escolha!=0)
            {
                Console.Clear();
                Console.WriteLine("Escolha: \n1–Ímpar \n2–Par \n0–Sair");
                escolha= int.Parse(Console.ReadLine());
                if (escolha == 0)
                {
                    Environment.Exit(0);
                }
                int n1 = gerador.Next(1, 101);
                if (escolha==2 && n1%2==0)
                {
                    jogador++;
                    Console.WriteLine("O número sorteado " + n1 + " é par!\r\nParabéns!");
                    Console.WriteLine("Computador- " + computador + "pts");
                    Console.WriteLine("Jogador- " + jogador + "pts");
                }
                else if (escolha == '1' && n1 % 2 == 0)
                {
                    computador++;
                    Console.WriteLine("O número sorteado " + n1 + " é par!\r\nErrou!");
                    Console.WriteLine("Computador- " + computador + "pts");
                    Console.WriteLine("Jogador- " + jogador + "pts");
                }
                else if (escolha == '1' && n1 % 2 != 0)
                {
                    jogador++;
                    Console.WriteLine("O número sorteado " + n1 + " é ímpar!\r\nParabéns!");
                    Console.WriteLine("Computador- " + computador + "pts");
                    Console.WriteLine("Jogador- " + jogador + "pts");

                }
                else if (escolha == '2' && n1 % 2 != 0)
                {
                    computador++;
                    Console.WriteLine("O número sorteado " + n1 + " é ímpar!\r\nErrou!");
                    Console.WriteLine("Computador- " + computador + "pts");
                    Console.WriteLine("Jogador- " + jogador + "pts");
                }
                

            }
            Console.ReadKey();
        }
    }
}
