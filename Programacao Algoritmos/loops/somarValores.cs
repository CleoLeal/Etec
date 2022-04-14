using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace somarValores
{
    class somarValores
    {
        static void Main(string[] args)
        {
            //Desenvolver um programa que recebe um número inteiro digitado e soma todos os
            //número de 1 até o número digitado e apresente o resultado abaixo. Utilize o loop For.
            //ok, certo!

            Console.WriteLine("Informe um número inteiro");
            int n1 = int.Parse(Console.ReadLine());
            int soma=0;
            for(int i=1; i<=n1; i++)
            {
                soma = soma + i;
                Console.Write("+" + i);
            }
            Console.Write("=" + soma);
            Console.ReadKey();
        }
    }
}
