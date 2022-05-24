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
            GerenciadorContas saldoTotal = new GerenciadorContas();

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
                            if(valor > 0)
                            {
                                cc.creditar(valor);
                                Console.WriteLine("Sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Não foi um  sucesso :(");
                            }
                            
                        }
                        else if (op == 2)
                        {
                            Console.WriteLine("Qual o valor que você quer sacar?");
                            double valor = double.Parse(Console.ReadLine());
                            cc.debitar(valor);
                        }
                        else if (op == 3)
                        {
                            Console.WriteLine("O seu saldo é:" + cc.getSaldo());
                        }
                        else if (op == 4)
                        {
                            cc.atualizarSaldos();
                            Console.Write("Saldo atualizado!");
                        }
                        else
                        {
                            break;
                        }
                        Console.ReadKey();
                    }
                    while (op != 0);
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
                            Console.WriteLine("Qual o valor que você quer depositar?");
                            double valor = double.Parse(Console.ReadLine());
                            if (valor > 0)
                            {
                                cp.creditar(valor);
                                Console.WriteLine("Sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Não foi um  sucesso :(");
                            }
                        }
                        else if (op == 3)
                        {
                            Console.WriteLine("O seu saldo é:" + cp.getSaldo());
                        }
                        else if (op == 4)
                        {
                            cp.atualizarSaldos();
                            Console.WriteLine("Saldo atualizado!");

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
            } while (opcao != 0);
        }
    }
}
