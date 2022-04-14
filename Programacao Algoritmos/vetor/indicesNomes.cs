using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indiceNomes
{
    class indiceNomes
    {
        static void Main(string[] args)
        {
            //Leia um array de 52 posições contendo as letras do Alfabeto Maiúsculas seguida das letras minúsculas. Faça um programa que mostre a sequência numérica dos índices do array que forme seu nome. Armazene os índices em um array de inteiros chamado índices.
            //ok, corrigido

            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                             'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] nome = "Cleo".ToCharArray();
            // int[] indices = new int[nome.Length];

            for (int i = 0; i < nome.Length; i++)
            {
                for(int n=0; i<letras.Length; n++)
                {
                    if (nome[i] == letras[n])
                    {
                        Console.WriteLine("Letra " + nome[i] + " - índice " + n);
                        break;
                    }
                   
                }
            }
            Console.ReadKey();
        }
    }
}
