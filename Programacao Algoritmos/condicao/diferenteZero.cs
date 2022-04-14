using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Um programa que leia dois números e apresente o total entre eles. Somente números diferentes de zero serão digitados.

            double n1, n2, soma;
            Console.WriteLine("Informe o número 1:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número 2:");
            n2 = double.Parse(Console.ReadLine());
            soma = n1 + n2;
            if(n1 == 0)
            {
                Console.WriteLine("O resultado inválido.");
            }
            else
            {
                Console.WriteLine("O resultado será:" + (soma));
            }
            Console.ReadKey();

        }
    }
}
