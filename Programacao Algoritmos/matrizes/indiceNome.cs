using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indiceNomes
{
    class indiceNome
    {
        static void Main(string[] args)
        {
            char[][] matriz = {
new char[] {'A','B','C','D','E','F','G','H','I','J','K','L',
'M','N','O','P','Q','R','S','T', 'U','V','W','X','Y','Z'},
new char[] {'a','b','c','d','e','f','g','h','i','j','k','l',
'm','n','o','p','q','r','s','t','u','v','w', 'x','y','z'},
new char[] {'0','1','2','3','4','5','6','7','8','9','-','.',' '}
};


            // Inicializar o array com os caracteres que formam seus nomes e números
            // Por exemplo, Cris seria formado pelos seguintes caracteres:
            char[][] dados = new char[2][];
            char[] nome = "Cristiane Tuji".ToCharArray();
            char[] RG = "12.345.678-9".ToCharArray();
            dados[0] = nome;
            dados[1] = RG;
            String[] indices = { "Índices do nome: ", "Índices do RG: " };

            // Criar o código que percorra o array contendo seus dados e busque os
            // índices de cada item na matriz. Para percorrer uma matriz são necessários dois for.
            // Para percorrer duas matrizes são necessários 4 for.

            Console.WriteLine("Indices = ");

            for (int z = 0; z < dados.Length; z++)
            {
                for (int i = 0; i < dados[z].Length; i++)
                {
                    for (int x = 0; x < matriz.Length; x++)
                    {
                        for (int y = 0; y < matriz[x].Length; y++)
                        {
                            if (dados[z][i] == matriz[x][y])
                            {
                                Console.WriteLine(dados[z][i] + " = " + x + " - " + y);
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
