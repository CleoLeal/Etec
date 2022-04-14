using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenar
{
    class ordenar
    {
        static void Main(string[] args)
        {
            //Faça um programa que gere e armazene em um array 10 valores gerados randomicamente – e os apresente na ordem em que foram gerados
            //ok

            int[] vetorGerado = new int[10];
            Random gerador = new Random();

            Console.WriteLine("Vetor Gerado");
            for(int i=0; i<vetorGerado.Length; i++)
            {
                vetorGerado[i] = gerador.Next(1, 101);
                Console.WriteLine(vetorGerado[i]);
            }

            Console.WriteLine("Vetor Ordenado");
            for (int i=0; i < vetorGerado.Length; i++)
            {
                for(int x=i+1; x<vetorGerado.Length; x++)
                {
                    if (vetorGerado[i] > vetorGerado[x])
                    {
                        int aux = vetorGerado[i];
                        vetorGerado[i] = vetorGerado[x];
                        vetorGerado[x] = aux;
                    } 

                }
                Console.WriteLine(vetorGerado[i]);
            }
            Console.ReadKey();
        }
    }
}
