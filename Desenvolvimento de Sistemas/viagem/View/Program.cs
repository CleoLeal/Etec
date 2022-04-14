using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Percurso percurso = new Percurso();
            Custos custos = new Custos();
            int opcao = 0;
            int km = 0;
            int combustivel = 0;
            int pedagio = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1 – Novo percurso\n2 – Listar percurso \n3 – Calcular custos \n0 – Sair");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("Informe\n Km percorrido");
                    km=int.Parse(Console.ReadLine());
                    percurso.setKmPercorrida(km);

                    Console.WriteLine("Valor do combustível");
                    combustivel = int.Parse(Console.ReadLine());
                    percurso.setValorCombustivel(combustivel);

                    Console.WriteLine("Valor do pedagio");
                    pedagio = int.Parse(Console.ReadLine());
                    percurso.setValorPedagio(pedagio);
                }

                else if (opcao == 2)
                {
                    Console.WriteLine(percurso.listarPercurso());
                }
                else if (opcao == 3)
                {
                    Console.WriteLine(custos.calcularViagem(percurso));
                }
                else if (opcao == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Esse número não está no menu");
                }
                Console.ReadKey();
            }
            while (opcao > 0);
            
        }
    }
}
