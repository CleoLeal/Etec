using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XdeUm
{
    class XdeUm
    {
        static void Main(string[] args)
        {
            //Declare uma matriz de char de 5 x 5. Preencha com 1 as diagonais e com 0 os demais elementos. Escreva ao final a matriz obtida.
            //ok
            
            char[][] diagonal = new char[5][];
            

            for (int i = 0; i < diagonal.Length; i++)
            {
                diagonal[i] = new char[5];
            }

            for (int i = 0; i < diagonal.Length; i++)
            {
                Console.WriteLine(" --------------------------");
                for (int x = 0; x < diagonal[i].Length; x++)
                {
                    Console.Write(" | ");
                    
                    Console.Write(diagonal[i][x]);
                    if ((x == i)||(x+i==4))
                    {
                        diagonal[i][x] = '1';
                        Console.Write(diagonal[i][x]);
                    }
                    else 
                    {
                        diagonal[i][x] = '0';
                        Console.Write(diagonal[i][x]);
                    }

                }
                Console.Write(" |\n");
            }
            Console.WriteLine(" --------------------------");
            
            Console.ReadKey();

        }
    }
}
