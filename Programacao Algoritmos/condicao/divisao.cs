using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Um algoritmo que leia dois números quaisquer, e escreva o resultado do cálculo do maior dividido pelo menor.

            double n1, n2;
            Console.WriteLine("Informe o número 1:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número 2:");
            n2 = double.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("O resultado será:" + (n1 / n2));
            }
            else
            {
                Console.WriteLine("O resultado será:" + (n2 / n1));
            }
            Console.ReadKey();
            


        }
    }
}
