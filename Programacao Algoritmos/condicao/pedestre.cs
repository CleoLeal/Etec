using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            //um algoritmo que informa se o pedestre tem que "SEGUIR" ou "ESPERAR".

            Console.WriteLine("Informe um número (1 ou 2):");
            char n1 = char.Parse(Console.ReadLine());
            if(n1=='1')
            {
                Console.WriteLine("SIGA!");
            }
            else if(n1 == '2')
            {
                Console.WriteLine("ESPERE!");
            }
            Console.ReadKey();
        }
    }
}
