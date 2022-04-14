using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inverterNumero
{
    class inverterNumero
    {
        static void Main(string[] args)
        {
            //Faça  um  programa  que  receba  um  número  entre  100  e  999.  Se  o  número  estiver  fora desta  faixa,
            // exiba  uma mensagem  ao  usuário  de  número  inválido. 
            //Caso o  número  seja válido, exiba o número digitado e o inverso do número digitado. 
            //Não converta o número em String para inverter. Utilize variáveis auxiliares do tipo int. Se a pessoa digitar 0, saia do programa.
            //Utilize o loop do whilepara repetir até que o usuário queira parar. Você vai precisar de pelo menos 3 variáveis auxiliares.
            //ok

            int num = 0, a, b, c;
            int contador = 0;
            while (contador<10)
            {
                Console.WriteLine("Informe um número entre 100 e 999\r\nPara sair digite 0");
                num = int.Parse(Console.ReadLine());
                if (num == '0')
                {
                    Environment.Exit(0);
                }
                else if(num<100 || num > 999)
                {
                    Console.WriteLine("Número inválido!!");
                    Environment.Exit(0);
                }
                else
                {
                    a = num / 100;
                    b = (num % 100) / 10;
                    c = num % 10;
                    Console.WriteLine("Número digitado- " + num);
                    Console.WriteLine("Número invertido- " + c + b + a);
                }
            }
            Console.ReadKey();
        }
    }
}
