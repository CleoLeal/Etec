using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impares
{
    class impares
    {
        static void Main(string[] args)
        {
            //10 posições númericas de numeros ímpares gerados aleatórios.
            //ok, certo

            int[] impares = new int[10];
            Random gerador = new Random();
            int contador = 0;
            while (contador<10)
            {
                int numero = gerador.Next(1, 100);
                if (numero % 2 == 1)
                {
                    impares[contador] = numero;
                    contador++;
                    Console.WriteLine(numero);
                }
                
            }
            Console.ReadKey();
        }
    }
}
