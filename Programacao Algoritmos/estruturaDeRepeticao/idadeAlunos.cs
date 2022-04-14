using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    class exercicio03
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que receba a idade de 50 alunos e mostre mensagem informando"maior de idade" e "menor de idade" 
            //para cada pessoa. Considere a idade a partir de 18 anos com o maior de idade.
            //Para ... de ... ate ... faça

            int idade, maior = 0, menor = 0 ;
            Random gerador = new Random();

            for (int i = 1; i <= 50; i++)
            {
                idade = gerador.Next(0,50);
                if (idade >1 && idade <= 18)
                {
                    menor++;
                }
                else
                {
                    maior++;
                }
                Console.WriteLine(idade);
            }
            Console.Write("Há " + menor + " alunos menores de idade e " + maior + " alunos maiores de idade");
            Console.ReadKey();
        }
    }
}
