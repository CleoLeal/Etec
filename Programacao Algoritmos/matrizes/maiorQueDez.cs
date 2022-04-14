using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maiorQueDez
{
    class maiorQueDez
    {
        static void Main(string[] args)
        {
            //Declare uma matriz de inteiros de 6 x 6, preencha com números aleatórios entre 1 a 100. Conte e escreva quantos valores maiores que 10 ela possui e a matriz.
            //ok

            Random gerador = new Random();
            int[][] diagonal = new int[6][];
            int contador = 0;

            for (int i = 0; i < diagonal.Length; i++)
            {
                diagonal[i] = new int[6];
            }

            for (int i = 0; i < diagonal.Length; i++)
            {
                Console.WriteLine(" ---------------------------------");
                for (int x = 0; x < diagonal[i].Length; x++)
                {
                    Console.Write(" | ");
                    diagonal[i][x] = gerador.Next(0, 101);
                    Console.Write(diagonal[i][x]);
                    if (diagonal[i][x]>10)
                    {
                        contador++;

                    }
                }
                Console.Write(" |\n");
            }
            Console.WriteLine(" ---------------------------------");
            Console.WriteLine("Existem " + contador + " números maiores que 10");
            
            Console.ReadKey();
        }
    }
}
