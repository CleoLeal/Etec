using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procurarPrimeiraOcorrencia
{
    class procurarPrimeiraOcorrencia
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[20];
            Random gerador = new Random();

            for(int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = gerador.Next(1, 10);
                Console.WriteLine(vetor[i]);
            }
            Console.WriteLine("Infome um número:");
            int n1 = int.Parse(Console.ReadLine());
            
            for(int i=0; i < vetor.Length; i++)
            {
               if (n1 == vetor[i])
               {
                 Console.WriteLine("O valor está na posição " + i);
                 Console.ReadKey();
                 Environment.Exit(0);
               }
                    
            }
            Console.WriteLine("O valor não foi encontrado");
            Console.ReadKey();
        }
    }
}
