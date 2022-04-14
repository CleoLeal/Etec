using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackJack
{
    class blackJack
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            char comecar = 's';
            int placarJogador = 0, placarBanca = 0, empate=0;
            while (comecar == 's')
            {
                Console.Clear();
                int n1 = gerador.Next(1, 11);
                int n2 = gerador.Next(1, 11);
                int n3 = gerador.Next(1, 11);
                int n4 = gerador.Next(1, 11);

                int somaJogador = n1 + n2;
                int somaBanca = n3 + n4;

                Console.WriteLine("Suas cartas são: " + n1 + " e " + n2 + "\n A soma delas são: " + somaJogador);
                char resposta = 's';
                while (resposta == 's')
                {
                    Console.WriteLine("Você quer mais cartas?(s/n)");
                    resposta = char.Parse(Console.ReadLine());
                    if (resposta == 's')
                    {
                        int carta = gerador.Next(1, 11);
                        somaJogador += carta;
                        Console.WriteLine("A sua carta sua nova carta é: " + carta + "\n A soma é: " + somaJogador);
                        if (somaJogador > 21)
                        {
                            Console.WriteLine("Você estourou!");
                            break;
                        }
                    }
                }
                Console.WriteLine("As cartas da banca é: " + n3 + " e " + n4 + "\n A soma é: " + somaBanca);
                if (somaJogador <= 21)
                {
                    while (somaBanca < somaJogador && somaBanca < 21)
                    {
                        int carta = gerador.Next(1, 11);
                        somaBanca += carta;
                        Console.WriteLine("A nova carta da banca é: " + carta + "\n A soma é: " + somaBanca);
                    }
                }
                if (somaBanca > 21)
                {
                    placarJogador++;
                    Console.WriteLine("A banca estourou");
                }
                else if (somaJogador > 21)
                {
                    placarBanca++;
                    Console.WriteLine("O jogador estourou");
                }
                else if (somaBanca == somaJogador)
                {
                    empate++;
                    Console.WriteLine("Empate!");
                }
                else if (somaBanca > somaJogador)
                {
                    placarBanca++;
                    Console.WriteLine("A banca ganhou");
                }
                else if (somaJogador > somaBanca)
                {
                    placarJogador++;
                    Console.WriteLine("Você ganhou!");
                }
                Console.WriteLine("====Placar====");
                Console.WriteLine("Jogador= " + placarJogador + " X " + "Banca= " + placarBanca + "\nEmpate= " + empate);
                Console.WriteLine("Você quer continuar?");
                comecar = char.Parse(Console.ReadLine());
                
            }
            
        }
    }
}

