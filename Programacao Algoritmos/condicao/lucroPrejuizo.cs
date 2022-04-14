using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.WriteLine("Informe a receita.");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a despesa");
            n2 = double.Parse(Console.ReadLine());
            if (n1 > n2)
            {
                Console.WriteLine("LUCRO");
            }
            else
            {
                Console.WriteLine("PREJUÍZO");
            }
            Console.ReadKey();
        }
    }
}
