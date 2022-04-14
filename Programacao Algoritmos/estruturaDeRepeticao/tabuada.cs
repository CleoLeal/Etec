using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada
{
    class Tabuada
    {
        static void Main(string[] args)
        {
            //tabuada
            Console.WriteLine("Informe um número inteiro!");
            int numero = int.Parse(Console.ReadLine());
            for (int i=1; i<=10; i++)
            {
                Console.WriteLine(i + "X" + numero +  "=" + i * numero);
            }
            Console.ReadKey();
        }
    }
}
