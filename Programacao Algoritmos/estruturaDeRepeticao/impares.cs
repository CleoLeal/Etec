using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    class exercicio01
    {
        static void Main(string[] args)
        {
            //Entrar com 100 números e informar ao final quantos são pares e quantos são ímpares.
            //Para ... de ... ate ... faça

            int numero, pares = 0, impares = 0;
            //gerar número aleatórios!
            Random gerador = new Random();

            for (int i = 1; i <= 10; i++) 
            {
                //1=valor mínimo. 104=valor máximo.
                numero = gerador.Next(1, 101);
                if (numero%2 == 00)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
                Console.WriteLine(numero);
            }
            Console.WriteLine("Foram gerados " + pares + " número pares e " + impares + " número ímpares");
            Console.ReadKey();
        }
    }
}
