using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            //um algoritmo que informa se o time de futebol foi BOM ou RUIM.
            double n1, n2;
            Console.WriteLine("Informe a quantidade de vitórias do time.");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de derrotas do time.");
            n2 = double.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("O time foi BOM!!");
            }
            else
            {
                Console.WriteLine("O time foi RUIM!!");
            }
            Console.ReadKey();
        }

    }
}
