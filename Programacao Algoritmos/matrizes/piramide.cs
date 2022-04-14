using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piramide
{
    class piramide
    {
        static void Main(string[] args)
        {
            //Declare uma matriz de char de 11 x 6 e desenhe uma pirâmide de * e exiba-a.
            //ok 

            char[][] piramide = new char[6][];
            for(int i=0; i<piramide.Length; i++)
            {
                piramide[i] = new char[11];
            }
            for (int i = 0; i < piramide.Length; i++)
            {
                Console.WriteLine(" ------------------------------------------");
                for (int x = 0; x < piramide[i].Length; x++)
                {
                    Console.Write(" | ");
                    if (x==5)
                    {
                        Console.Write("*");
                    }
                    if ((x==4) && (i>0))
                    {
                        Console.Write("*");
                    }
                    if ((x == 3) && (i > 1))
                    {
                        Console.Write("*");
                    }
                    if ((x == 2) && (i > 2))
                    {
                        Console.Write("*");
                    }
                    if ((x == 1) && (i > 3))
                    {
                        Console.Write("*");
                    }
                    if ((x == 0) && (i > 4))
                    {
                        Console.Write("*");
                    }
                    if((x==6) && (i > 0))
                    {
                        Console.Write("*");
                    }
                    if ((x == 7) && (i > 1))
                    {
                        Console.Write("*");
                    }
                    if ((x == 8) && (i > 2))
                    {
                        Console.Write("*");
                    }
                    if ((x == 9) && (i > 3))
                    {
                        Console.Write("*");
                    }
                    if ((x == 10) && (i > 4))
                    {
                        Console.Write("*");
                    }
                }

                Console.Write(" |\n");
            }
            Console.WriteLine("  ------------------------------------------");
            Console.ReadKey();

        }
    }
}
