using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancario
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1 – Depositar\n2 – Sacar\n3 – Transferir\n4 – Consultar saldo\n0 – Sair");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("Informe um valor para depositar");
                    double valor = double.Parse(Console.ReadLine());
                    conta.depositar(valor);
                    Console.WriteLine("Deposito efetuado com sucesso");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Informe um valor para sacar");
                    double valor = double.Parse(Console.ReadLine());
                    if (conta.sacar(valor))
                    {
                        Console.WriteLine("Saque efetuado com sucesso");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insuficiente");
                    }
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("Informe um valor para transferir");
                    double valor = double.Parse(Console.ReadLine());
                    conta.transferir(valor, new Conta());
                }
                else if (opcao == 4)
                {
                    Console.WriteLine(conta.ConsultarSaldo());
                }
                else if (opcao == 0)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
                Console.ReadKey();
            } while (opcao != 0);
        }
    }
}
