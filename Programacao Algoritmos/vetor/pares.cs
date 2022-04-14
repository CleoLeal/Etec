using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pares
{
    class pares
    {
        static void Main(string[] args)
        {
            //Declare um array de inteiros de 40 posições, preencha com números aleatórios. Contar e exibir quantos valores pares ele possui e exibir o array gerado.
            //ok

            int[] vetor = new int[40];
            Random gerador = new Random();
            int pares = 0;

            Console.Write("| ");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = gerador.Next(1, 100);
                Console.Write(vetor[i] + " | ");
                if (vetor[i] % 2 == 0)
                {
                    pares++;
                }
            }

            Console.WriteLine("\n\nForam gerados " + pares + " números pares!");
            Console.ReadKey();
        }
    }
}
