using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeDeSoma
{
    class testeDeSoma
    {
        static void Main(string[] args)
        {
            //Deselvolva um progama que apresente uma expressão de soma de dois números obtidos randomicamente
            //(de 1 a 10), caso o usuário digite  resposta errada, peça que ele tente novamente, se ele acertar,
            //dê o parbéns. Conte quntas vezes ele acertou e apresente o porcentual de acertos a cada jogada. 
            //para sair, peça que ele digite 0. Utilize o loop while.
            //ok, certo!

            Random gerador = new Random();
            int contador = 0;
            int jogada = 0;
            int acerto = 0;
            int resposta = -1;
            while (resposta!=0)
            {
                jogada++;
                int n1 = gerador.Next(1,11);
                int n2 = gerador.Next(1,11);
                Console.Clear();
                Console.WriteLine("Quanto é " + n1 + "+" + n2 + "?");
                resposta = int.Parse(Console.ReadLine());
                if (resposta == 0)
                {
                    Environment.Exit(0);
                }

                else if (resposta==n1+n2)
                {
                    acerto++;
                    Console.WriteLine("Parabéns!");

                }
                else
                {
                    Console.WriteLine("Tente novamente!");
                }
                int porcentagem = acerto * 100 / jogada;
                Console.WriteLine("o seu porcentual de acerto é " + porcentagem + "%");
            }
            Console.ReadKey();          

        }
    }
}
