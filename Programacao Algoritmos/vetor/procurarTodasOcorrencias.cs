using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procurarTodasOcorrencias
{
    class procurarTodasOcorrencias
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[100];
            Random gerador = new Random();
            string msg = "";

            Console.WriteLine("Informe um número de 1 a 100 a ser pesquisado no vetor");
            int num = int.Parse(Console.ReadLine());

            Console.Write("| ");
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = gerador.Next(1, 100);
                Console.Write(vetor[i] + " | ");
            }

            for (int i = 0; i < vetor.Length; i++)
            {
                if (num == vetor[i])
                {
                    msg += "\nO numero " + num + " ocorre na posição " + i;
                }
            }
            if (msg.Length == 0)
            {
                msg = "\nO número " + num + " não foi encontrado no vetor!";
            }
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
