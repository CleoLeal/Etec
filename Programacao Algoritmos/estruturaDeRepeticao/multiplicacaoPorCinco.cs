using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio07
{
    class exercicio07
    {
        static void Main(string[] args)
        {
            //Faça um programa que leia um número, multiplique-o por 5, mostre o resultado
            //e pergunte se o usuário quer continuar. Se sim, repita o procedimento.
            //Enquanto...faca...fim_enquanto

            char continuar = 's';
            while(continuar=='s' || continuar=='S')
            {
                Console.WriteLine("Digite um número");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Resulsultado= " + numero * 5);
                Console.WriteLine("Deseja continuar?(s/n)");
                continuar = char.Parse(Console.ReadLine());

            }

        }
    }
}
