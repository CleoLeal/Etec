using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um Programa que escreva todos os múltiplos de 7, do intervalo de 1 a 1500
            //Repita...ate_que

            int n = 0;
            do
            {
                n = n + 7;
                Console.WriteLine(n);
            } while (n <= 1500);
            Console.ReadKey();
        }
    }
}
