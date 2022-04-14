using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeFatorial
{
    class classeFatorial
    {
        static void Main(string[] args)
        {
            //Desenvolver um programa que recebe um número inteiro digitado e soma todos os números
            // de 1 até o número digitado e apresente o resultado abaixo. Utiliza o loop for.
            //ok, certo!

            Console.WriteLine("Informe um número inteiro");
            int n1 = int.Parse(Console.ReadLine());
            int multi=1;
            for (int i = 1; i <= n1; i++)
            {
                multi = multi * i;
                Console.Write("*" + i);
            }
            Console.Write("=" + multi);
            Console.ReadKey();
        }
    }
}
