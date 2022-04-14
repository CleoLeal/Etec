using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class palindrome
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba uma palavra digitada pelo usuário e verifique se essa palavra é palíndrome.
            //terminar

            Console.WriteLine("Qual palavra você quer que invertemos?");
            string palavra = Console.ReadLine();
            char[] vetor = palavra.ToCharArray();
            string inverso = "";

            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                inverso = inverso + vetor[i];
            }
            if (palavra == inverso)
            {
             Console.WriteLine("A palavra " + palavra + " é palíndrome ");
            }
            else
            {
                Console.WriteLine("A palavra " + palavra + " não é palíndrome ");
            }
            Console.ReadKey();
        }
    }
}
