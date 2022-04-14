using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progressaoAritmetica
{
    class progressaoAritmetica
    {
        static void Main(string[] args)
        {
            //Crie um programa que receba um número digitado pelo usuário, uma razãoe o limite. 
            //Calcule os termos de  uma P.A (Progressão Aritmética),  armazenando esses  valores  em uma  String. 
            //Exiba  os  números  obtidos.  Progressão  aritmética  é  uma sequênciade números somados a um valor constante.
            //formula: an=a1+(n-1)*r
            //formula n: a2=a1+(2-1)*r

            int a1,razao, limite;

            Console.WriteLine("Informe o primeiro termo:");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a razão:");
            razao = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o limite:");
            limite = int.Parse(Console.ReadLine());
            for(int i = 0; i<limite; i++)
            {
                int formula= a1+razao * i;
                Console.Write("," + (a1 + (i-1)*razao));
            }

            Console.ReadKey();

        }
    }
}
