using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiroDamas
{
    class tabuleiroDamas
    {
        static void Main(string[] args)
        {
            //Crie um programa que represente no console um tabuleiro de damas no estado inicial. Utilize uma matriz de char de 8 x 8. Para representar as pedras brancas utilize o 0 para representar as pedras pretas utilize o *. Para as casas vazias armazene um espaço em branco na matriz.
            //ok

            char[][] tabuleiro = new char[8][];

            for (int i = 0; i < tabuleiro.Length; i++)
            {
                tabuleiro[i] = new char[8];
            }

            for (int i=0; i<tabuleiro.Length; i++)
            {
                Console.WriteLine(" ---------------------------------");
                for (int x = 0; x < tabuleiro[i].Length; x++)
                {
                    Console.Write(" | ");
                    if ((i == 0 && x % 2 == 1)||(i == 1 && x % 2 == 0))
                    {
                        tabuleiro[i][x] = '0';
                        Console.Write(tabuleiro[i][x]);
                    } else if ((i == 6 && x % 2 == 0) || (i == 7 && x % 2 == 1))
                    {
                        tabuleiro[i][x] = '*';
                        Console.Write(tabuleiro[i][x]);
                    }
                    else 
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write(" |\n");
            }
            Console.WriteLine(" ---------------------------------");
            Console.ReadKey();
            

        }
    }
}
