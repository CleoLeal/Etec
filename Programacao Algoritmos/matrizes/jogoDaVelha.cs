using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogoDaVelha
{
    class jogoDaVelha
    {
        static void Main(string[] args)
        {
            //Crie um tabuleiro de jogo da velha, em uma matriz de char de 3x3 e preencha com 0 e X alternadamente, começando sempre por 0. O valor deve ser preenchido no local indicado pelo usuário, o usuário precisa indicar o local informando a linha e a coluna
            //

            char[][] jogo = new char[3][];
            for (int i = 0; i < jogo.Length; i++)
            {
                jogo[i] = new char[3];
            }


            for (int i = 0; i < jogo.Length; i++)
            {
                Console.WriteLine("Em qual Linha você quer por o 0?");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Em qual Coluna você quer por o 0?");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine(" ------------------------------");
                for (int x = 0; x < jogo[i].Length; x++)
                {
                    Console.Write(" | ");

                    Console.Write(jogo[i][x]);

                    if (i == n1 && x == n2)
                    {
                        jogo[x][i] = 'O';
                        Console.Write(jogo[i][x]);
                    }

                }

                Console.ReadKey();
            }
        }
    }
}
