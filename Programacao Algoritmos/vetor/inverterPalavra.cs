using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverterPalavra
{
    class inverterPalavra
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba uma palavra e exiba a palavra digitada e a mesma palavra invertida.
            //ok, certo

            Console.WriteLine("Qual palavra você quer que invertemos?");
            string palavra = Console.ReadLine();
            char[] vetor = palavra.ToCharArray();
            Console.Write(palavra + " - ");
            for (int i = palavra.Length-1; i >=0; i--)
            {
                string word = Convert.ToString(palavra[i]);
                Console.Write(vetor[i]);
            }
            Console.ReadKey();

            //corrigido
            //Console.WriteLine("Qual palavra você quer que invertemos?");
            //string palavra = Console.ReadLine();
            //char[] vetor = palavra.ToCharArray();
            //string inverso = "";

            //for (int i = vetor.Length - 1; i >= 0; i--)
            //{
            //    inverso = inverso + vetor[i];
            //}
            //Console.WriteLine("O inverso de " + palavra + " é " + inverso);
            //Console.ReadKey();
        }
    }
}
