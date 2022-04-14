using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagrama
{
    class anagrama
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a primeira palavra");
            char[] palavra = Console.ReadLine().ToCharArray();
            Console.WriteLine("Informe a segunda palavra");
            char[] anagrama = Console.ReadLine().ToCharArray();
            string msg = "";
            if (palavra.Length != anagrama.Length)
            {
                msg = "As palavras não são anagramas!";
            }
            else
            {
                for (int i = 0; i < anagrama.Length; i++)
                {
                    for (int x = 0; x < palavra.Length; x++)
                    {
                        if (anagrama[i] == palavra[x])
                        {
                            palavra[x] = ' ';
                        }
                    }
                }

                for (int x = 0; x < palavra.Length; x++)
                {
                    if (palavra[x] != ' ')
                    {
                        msg = "As palavras não são anagramas!";
                    }
                }

                if (msg.Length == 0)
                {
                    msg = "As palavras são anagramas!";
                }
            }
            Console.WriteLine(msg);
            Console.ReadKey();
        }
    }
}
