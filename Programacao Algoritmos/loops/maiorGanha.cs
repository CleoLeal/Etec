using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maiorGanha
{
    class maiorGanha
    {
        static void Main(string[] args)
        {
            //Faça  um  programa  que  exiba  um  número  de  1  a  100obtido  randomicamente  para  o usuárioe   pergunte   se   ele   quer   apostar. 
            //Se sim,   gere   outro número   obtido randomicamente. Se o número recebido pelo usuário for maior, pontue o usuário, 
            //se o número apresentado para o computador for maior, pontue o computador, se os números forem iguais, não pontue ninguém. 
            //exiba o placar a cada jogada. Utilize o loop do while.
            //ok, certo!

            int jogadas = 0, computador=0, jogador=0;
            Random gerador = new Random();
            
            char repetir = 's';
            do
            {    
                int n1 = gerador.Next(100);
                jogadas++;
                Console.WriteLine("O seu numéro gerado é " + n1 + ". Apostar?\r\n" + "S ou N");
                repetir = char.ToUpper(char.Parse(Console.ReadLine()));//char.ToUpper é para converter para letras maiúsculas.
                if (repetir != 'S')
                {
                    break;
                }
                int n2 = gerador.Next(100);
                if (n1 > n2)
                {
                   
                    jogador++;
                    Console.WriteLine("Parabéns! \r\n" + "O número gerado foi " + n2 + "!");
                    Console.WriteLine("Jogadas- " + jogadas + "\r\nComputador- " + computador + "\r\nJogador- " + jogador);
                }
                else if(n2 > n1)
                {
                    
                    computador++;
                    Console.WriteLine("Perdeu! \r\n" + "O número gerado foi " + n2 + "!");
                    Console.WriteLine("Jogadas- " + jogadas + "\r\nComputador- " + computador + "\r\nJogador- " + jogador);
                }
                else
                {
                    Console.WriteLine("Empatou! Os números são iguais.");
                    Console.WriteLine("Jogadas- " + jogadas + "\r\nComputador- " + computador + "\r\nJogador- " + jogador);
                }
            } while (repetir == 's' || repetir == 'S');
            Console.ReadKey();
        }
    }
}
