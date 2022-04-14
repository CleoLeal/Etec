using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            Console.WriteLine("Informe o seu salário:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor da sua prestação:");
            n2 = double.Parse(Console.ReadLine());
            if (n2 <= n1 * 0.3)
            {
                Console.WriteLine("O financiamento foi aprovado!");
            }
            else
            {
                Console.WriteLine("O financiamento foi recusado!");
            }
            Console.ReadKey();
        }
    }
}
