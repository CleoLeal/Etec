using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buscarValor
{
    class buscarValor
    {
        static void Main(string[] args)
        {
            //Declare uma matriz de inteiros de 20 x 20 e preencha com números aleatórios. Receba um valor informado pelo usuário. 
            //O programa deverá fazer uma busca desse valor na matriz e, exibir a localização (linha e coluna) de cada uma das ocorrências ou uma mensagem de “não encontrado”. Exiba também a matriz.
            //terminar


            Random gerador = new Random();
            int[][] matriz = new int[20][];
            Console.WriteLine("Informe um número para procurarmos na matirz");
            int n1 = int.Parse(Console.ReadLine());
            string msg = "O valor " + n1 +  " está em:\n", locais="";

            for (int i = 0; i < matriz.Length; i++)
            {
                matriz[i] = new int[20];
            }

            for (int i = 0; i < matriz.Length; i++)
            {
                Console.WriteLine(" ---------------------------------------------------------------------------------");
                for (int x = 0; x < matriz[i].Length; x++)
                {
                    Console.Write(" | ");
                    matriz[i][x] = gerador.Next(1, 10);
                    Console.Write(matriz[i][x]);
                    if (n1 == matriz[i][x])
                    {
                        locais +=" linha " + i + " e coluna " + x + "\n";
                        
                    }
                }
                
                Console.Write(" |\n");
            }
            Console.WriteLine(" ---------------------------------------------------------------------------------");
            if (locais.Length > 0)
            {
                Console.WriteLine(msg + locais);
            }
            else
            {
                Console.WriteLine(msg + "Lugar nenhum");
            }
            Console.ReadKey();
        }
    }
}
