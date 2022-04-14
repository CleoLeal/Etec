using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
    class exercicio04
    {
        static void Main(string[] args)
        {
            //um programa que escreve os números de 1 até 20.
            //Enquanto...faca...fim_enquanto

            int contador = 0;
            while (contador <= 20)
            {
                Console.WriteLine(contador);
                contador += 1;//ou contador ou contador +1. mesmo comando
            }
            Console.ReadKey();
        }
    }
}
