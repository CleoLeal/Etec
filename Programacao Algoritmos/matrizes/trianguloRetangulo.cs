using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloRetangulo
{
    class TrianguloRetangulo
    {
        static void Main(string[] args)
        {
            //Declare uma matriz de char de 6 x 6, e desenhe um triangulo retângulo conforme exemplo: Exiba a matriz
            //ok

            char[][] matriz = new char[6][];
            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new char[6];
            }
            for (int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine(" ------------------------------");
                for (int x = 0; x < matriz[i].Length; x++)
                {
                    Console.Write(" | ");
                    
                    Console.Write(matriz[i][x]);
                    
                    if (x == i)
                    {
                        matriz[x][i] = '*';
                        Console.Write(matriz[x][i]);
                    }
                    if (x + 1 == i)
                    {
                        matriz[x][i] = '*';
                        Console.Write(matriz[x][i]);
                    }
                    if (x + 2 == i)
                    {
                        matriz[x][i] = '*';
                        Console.Write(matriz[x][i]);
                    }
                    if (x + 3 == i)
                    {
                        matriz[x][i] = '*';
                        Console.Write(matriz[x][i]);
                    }
                    if (x + 4 == i)
                    {
                        matriz[x][i] = '*';
                        Console.Write(matriz[x][i]);
                    }
                    if (x + 5 == i)
                    {
                        matriz[x][i] = '*';
                        Console.Write(matriz[x][i]);
                    }

                }
                
                Console.Write(" |\n");
            }
            Console.WriteLine("  ------------------------------");
            Console.ReadKey();

        }
    }
}
