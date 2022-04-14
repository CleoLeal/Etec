using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maiorValor
{
    class maiorValor
    {
        static void Main(string[] args)
        {
            //Leia uma matriz 10 x 10 e escreva a localização (linha e a coluna) do maior valor.
            //ok

            Random gerador = new Random();
            int[][] matriz = new int[10][];// matriz de 10 linhas
            int maior = 0;

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[10];//cada linha tem 10 colunas
            }

            for (int x = 0; x < matriz.Length; x++)
            {
                for (int y = 0; y < matriz[x].Length; y++)
                {
                    matriz[x][y] = gerador.Next(1, 10);
                    if (matriz[x][y] > maior)
                    {
                        maior = matriz[x][y];
                    }
                    Console.Write("[" + x + "]" + "[" + y + "]" + matriz[x][y] + " - ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Maior = " + maior);
            Console.ReadKey();
        }
    }
}
