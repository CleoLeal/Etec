using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente(500, 1000);
            ContaPoupanca cp = new ContaPoupanca(5000, 0.01);
            GerenciadorContas saldoTotal = new GerenciadorContas(0);

            int opcao = 0;
            int op = 0;
            do
            {
                Console.WriteLine("1 - Conta Corrente \n2 - Poupança \n3 - Consultar total dos saldos \n0 - sair");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1 – Depositar \n2 – Sacar \n3 – Consultar saldo \n4 – Reajustar saldo \n0 – Sair");
                        op=int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            Console.WriteLine("Qual o valor que você quer depositar?");
                            double valor = double.Parse(Console.ReadLine());
                            cc.creditar(valor);
                            Console.WriteLine("Sucesso!");
                        }
                        else if (op == 2)
                        {
                            Console.WriteLine("Qual o valor que você quer sacar?");
                            double valor = double.Parse(Console.ReadLine());
                            if (cc.debitar(valor))
                            {
                                Console.WriteLine("Você realizou o saque!");
                            }
                            else
                            {
                                Console.WriteLine("O saque não foi realizado!");
                            }
                        }
                        else if (op == 3)
                        {
                            Console.WriteLine("O seu saldo é:" + cc.getSaldo());
                        }
                        else if (op == 4)
                        {
                            Console.WriteLine("O saldo foi atualizado");
                            cc.atualizarSaldos();
                        }
                        else
                        {
                            break;
                        }
                    }
                    while (op != 0);
                    Console.ReadKey();
                }
                else if (opcao == 2)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1 – Depositar \n2 – Sacar \n3 – Consultar saldo \n4 – Reajustar saldo \n0 – Sair");
                        op = int.Parse(Console.ReadLine());
                        if (op == 1)
                        {
                            Console.WriteLine("Qual o valor que você quer depositar?");
                            double valor = double.Parse(Console.ReadLine());
                            cp.creditar(valor);
                            Console.WriteLine("Sucesso!");
                        }
                        else if (op == 2)
                        {
                            Console.WriteLine("Qual o valor que você quer sacar?");
                            double valor = double.Parse(Console.ReadLine());
                            if (cp.debitar(valor))
                            {
                                Console.WriteLine("Você realizou o saque!");
                            }
                            else
                            {
                                Console.WriteLine("O saque não foi realizado!");
                            }
                        }
                        else if (op == 3)
                        {
                            Console.WriteLine("O seu saldo é:" + cp.getSaldo());
                        }
                        else if (op == 4)
                        {
                            cp.atualizarSaldos();
                        }
                        else
                        {
                            break;
                        }
                        Console.ReadKey();
                    }
                    while (op != 0);
                }
                else if(opcao==3)
                {
                    Console.WriteLine("O saldo total da conta corrente é: ");
                    saldoTotal.totalizarSaldos(cc);
                    Console.WriteLine("O saldo total da conta poupança é: ");
                    saldoTotal.totalizarSaldos(cp);
                    Console.ReadKey();
                }
                else
                {
                    Environment.Exit(0);    
                }
                Console.ReadKey();
            } while (op != 0);
        }
    }
}
