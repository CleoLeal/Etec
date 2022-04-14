using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            //um programa que informa qual número é maior que o outro.
            
            double n1, n2, inteiro;
            Console.WriteLine("Informe o primeiro número:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            n2 = double.Parse(Console.ReadLine());
            if (n1 >= n2) 
            {
                Console.WriteLine("O " + n1 + " é maior que " + n2);
            }
            else
            {
                Console.WriteLine("O " + n2 + " é maior que " + n1);
            } 
            Console.ReadKey();

        }
    }
}