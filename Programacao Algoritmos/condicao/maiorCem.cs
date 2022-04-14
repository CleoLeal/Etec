using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Um Programa que leia um número e escreva “maior do que 100”,
            //se o número digitado for maior que 100 escreva “menor do que 100”,se o número for menor do que 100.

            int n1;
            Console.WriteLine("Informe um número:");
            n1 = int.Parse(Console.ReadLine());
            if (n1 > 100)
            {
                Console.WriteLine("O " + n1 + " é maior que 100.");
            }
            else
            {
                Console.WriteLine("O " + n1 + " é menor que 100.");
            }
            Console.ReadKey();
        }
    }
}
