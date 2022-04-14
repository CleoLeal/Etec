using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverterFrase
{
    class inverterFrase
    {
        static void Main(string[] args)
        {
            //Faça um programa que receba uma frase digitada pelo usuário e exiba a mesma frase com cada palavra invertida.
            //ok.

            Console.WriteLine("Qual frase você quer que invertemos?");
            string frase =Console.ReadLine();
            string[] palavra = frase.Split(' ');
            string inverso = " ";

            for(int x=0; x < palavra.Length; x++)
            {
                char[] letras = palavra[x].ToCharArray();

                for (int i = letras.Length - 1; i >= 0; i--)
                {
                    inverso = inverso + letras[i];

                }
                inverso = inverso + " ";
            }
            Console.WriteLine("o inverso de " + frase + " é " + inverso);           
            Console.ReadKey();
        }
    }
}
