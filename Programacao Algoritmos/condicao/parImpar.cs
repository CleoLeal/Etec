using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //um algoritmo que informa se o número é par ou ímpar.
            double n1;
            Console.WriteLine("Informe um número");
            n1 = double.Parse(Console.ReadLine());
            //se o número é divisivel por 2, ele é par. Senão, ele é ímpar.
            if (n1 % 2 == 0)
            {
                Console.WriteLine("O número " + n1 + " é par!");
            }
            else
            {
                Console.WriteLine("O número " + n1 + " é ímpar!");
            }
            Console.ReadKey();
        }
    }
}
