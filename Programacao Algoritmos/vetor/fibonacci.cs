using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class fibonacci
    {
        static void Main(string[] args)
        {
            // programa com a regra de fibonacci
            //ok,certo

            Console.WriteLine("Qual o termo da Fibonacci desejado?");
            int i = int.Parse(Console.ReadLine());
            int[] Fibonacci = new int[i];
            Console.WriteLine();
            for (int x = 0; x < i; x++)
            {
                if (x == 0)
                {
                    Fibonacci[x] = 0;
                }
                else if (x == 1)
                {
                    Fibonacci[x] = 1;
                }
                else
                {
                    Fibonacci[x] = Fibonacci[x - 1] + Fibonacci[x - 2];
                }

                Console.WriteLine(Fibonacci[x]);
            }
            Console.ReadKey();
            //Console.Write(Fibonacci[i - 1]);

            // fibonacci[0] = 0, 
            //fibonacci[1] = 1, 
            //fibonacci[2] = 1,
            //fibonacci[3] =
            //fibonacci[4] =
        }
    }
}
