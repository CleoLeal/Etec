using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    class exercicio02
    {
        static void Main(string[] args)
        {
            //Ler 80 números e ao final informar quantos números estão no intervalo entre 10 (inclusive) e 150 (inclusive).
            //Para ... de ... ate ... faça

            int numero, faixa = 0;
            Random gerador = new Random();

            for(int i = 1; i<=80; i++)
            {
                numero = gerador.Next(0, 1000);
                if (numero >=10 && numero <= 150)
                {
                    faixa++;
                }
                Console.WriteLine(numero);
            }
            Console.Write("Foram gerados " + faixa + " numeros entre 10 e 150");
            Console.ReadKey();
        }
    }
}
