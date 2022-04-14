using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomes
{
    class nomes
    {
        static void Main(string[] args)
        {
            //programa para armazenar nomes
            //ok, certo

            string[] alunos = new string[10];
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Informe o nome do aluno presente na aula:");
                alunos[i] = Console.ReadLine();
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((i+1) + " - " + alunos[i] + " - presente");
               
            }
            Console.ReadKey();

        }
    }
}
