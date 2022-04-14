using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeDiagonal
{
    class classeDiagonal
    {
        static void Main(string[] args)
        {
            //Declare uma matriz de inteiros de 8x8 e preencha com números aleatóros. Some os elementos das diagonais. Apresente a matriz e as somas das diagonais.
            //ok

            Random gerador = new Random();
            int[][] diagonal = new int[8][];
            int total = 0;
            int total2 = 0;

            for (int i = 0; i < diagonal.Length; i++)
            {
                diagonal[i] = new int[8];
            }

            for (int i = 0; i < diagonal.Length; i++)
            {
                Console.WriteLine(" ---------------------------------");
                for (int x = 0; x < diagonal[i].Length; x++)
                {
                    Console.Write(" | ");
                    diagonal[i][x] = gerador.Next(0, 10);
                    Console.Write(diagonal[i][x]);
                    if (x == i)
                    {
                        total = total + diagonal[i][x];

                    }
                    if (x+i==7)
                    {
                        total2 = total2 + diagonal[i][x];

                    }
                }
                Console.Write(" |\n");
            }
            Console.WriteLine(" ---------------------------------");
            Console.WriteLine("Primeira diagonal: " + total);
            Console.WriteLine("Segunda diagonal: " + total2);
            Console.ReadKey();
        }
    }
}
