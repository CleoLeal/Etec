using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06
{
    class exercicio06
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia 10 valores inteiros e escreva no final a soma dos valores lidos
            //Enquanto...faca...fim_enquanto

            Random gerador = new Random();//para gerar números aleatórios
            int contador=1, totalizador=0;//contador para controlar o loop

            while (contador <= 10)//loop
            {
                int numero = gerador.Next(100);//até que número ele pode gerar
                Console.WriteLine( contador +  " o. número " + numero);
                totalizador += numero;
                contador++;
            }
            Console.WriteLine("Total " + totalizador);
            Console.ReadKey();

        }
    }
}
