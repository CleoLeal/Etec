using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trocarPosicoes
{
    class trocaPosicoes
    {
        private const int V = 9;

        static void Main(string[] args)
        {
            //Declare um array de inteiros de 16 posições, preencha com números gerados aleatoriamente, troque os 8 primeiros valores pelos 8 últimos. Mostre o array original e o array final.
            //ok, corrigido

            int[] array = new int[16];
            Random gerador = new Random();

            Console.WriteLine("Números gerados: ");
            for(int i=0; i < array.Length; i++)
            {
                array[i] = gerador.Next(1, 50);
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Números gerados trocados de posição:");
            for(int i = 0; i < array.Length/2; i++)
            {
                int aux = array[i];
                array[i] = array[i+8];
                array[i+8] = aux;
                Console.WriteLine(array[i]);
            }

            for(int i=8; i<array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
           
            Console.ReadKey();
        }
    }
}
