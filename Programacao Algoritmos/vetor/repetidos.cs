using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetidos
{
    class repetidos
    {
        static void Main(string[] args)
        {
            //Declare um array de 100 posições, preencha e verifique se existem valores iguais. 
            //Escreva os valores que se repetem e quantas vezes ocorre a repetição.
            //fazendo

            int[] vetor = new int[100];
            Random gerador = new Random();

            Console.Write("| ");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = gerador.Next(1, 100);
                Console.Write(vetor[i] + " | ");
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] != 0)
                {
                    int num = vetor[i];
                    int repetidos = 1;
                    for (int x = i + 1; x < vetor.Length; x++)
                    {
                        if (num == vetor[x] && vetor[x] != 0)
                        {
                            repetidos++;
                            vetor[x] = 0;
                        }
                    }
                    if (repetidos > 1)
                    {
                        Console.WriteLine("\nO número " + vetor[i] + " ocorre " + repetidos + " vezes");
                    }
                    else
                    {
                        Console.WriteLine("\nO número " + vetor[i] + " ocorre uma única vez ");
                    }
                }
            }
            Console.ReadKey();
        }

    }
}
