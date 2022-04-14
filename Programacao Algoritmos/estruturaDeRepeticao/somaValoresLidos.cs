using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um Programa que leia números até que o usuário não queira mais digitar os números. No final escrever a soma dos valores lidos.
            //Repita...ate_que

            int total = 0, numero;
            char repetir = 's';
            do
            {
                Console.WriteLine("Informe um número qualquer");

                numero = int.Parse(Console.ReadLine());
                total = total + numero;
                Console.WriteLine("Deseja continuar? (s/n)");
                repetir = char.Parse(Console.ReadLine());
            } while (repetir == 's' || repetir == 'S');
            Console.WriteLine("A soma dos números informados é=" + total);
            Console.ReadKey();
        }
    }
}
