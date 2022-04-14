using bancarioHeranca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancarioHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta();
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca();

            
            int op = 0;
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1 – Conta Corrente \n2 – Conta Poupança\n0 - Sair");
                op=int.Parse(Console.ReadLine());
                if(op==1)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1 – Depositar \n2 – Sacar\n3 - Transferir\n4 - Consultar Saldo\n5 - Calcular juros cheque especial\n0 - Sair");
                        opcao= int.Parse(Console.ReadLine());
                        if (opcao == 1)
                        {
                            Console.WriteLine("Qual o valor que você quer depositar?");
                            double valor = double.Parse(Console.ReadLine());
                            cc.depositar(valor);
                            Console.WriteLine("Sucesso!");
                        }
                        else if (opcao == 2)
                        {
                            Console.WriteLine("Qual o valor que você quer sacar?");
                            double valor = double.Parse(Console.ReadLine());
                            if(cc.sacar(valor))
                            {
                                Console.WriteLine("Você realizou o saque!");
                            }
                            else
                            {
                                Console.WriteLine("O saque não foi realizado!");
                            }
                        }
                        else if (opcao == 3)
                        {
                            Console.WriteLine("Qual o número da sua para a transferência?");
                            conta.setNumero(int.Parse(Console.ReadLine()));
                            Console.WriteLine("Qual o valor da sua para a transferência?");
                            double valor = double.Parse(Console.ReadLine());
                            cc.transferir(valor, new ContaCorrente());
                            Console.WriteLine("A transferência foi realizada!");
                        }
                        else if (opcao == 4)
                        {
                            Console.WriteLine(cc.consultarSaldo());
                        }
                        else if (opcao == 5)
                        {
                            Console.WriteLine("Informe a sua taxa em %: ");
                            double taxa = double.Parse(Console.ReadLine());
                            cc.calcularJuros(taxa);
                        }
                        else
                        {
                            break;
                        }
                        Console.ReadKey();
                    }
                    while (op != 0);
                }
                else if (op == 2)
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1 – Depositar \n2 – Sacar\n3 - Transferir\n4 - Consultar Saldo\n5 - Calcular Reajuste Mensal\n0 - Sair");
                        opcao= int.Parse(Console.ReadLine());
                        if (opcao == 1)
                        {
                            Console.WriteLine("Qual o valor que você quer depositar?");
                            double valor = int.Parse(Console.ReadLine());
                            cp.depositar(valor);
                            Console.WriteLine("Sucesso!");
                        }
                        else if (opcao == 2)
                        {
                            Console.WriteLine("Qual o valor que você quer sacar?");
                            double valor = int.Parse(Console.ReadLine());
                            if (cp.sacar(valor))
                            {
                                Console.WriteLine("Você realizou o saque!");
                            }
                            else
                            {
                                Console.WriteLine("O saque não foi realizado!");
                            }
                        }
                        else if(opcao == 3)
                        {
                            Console.WriteLine("Qual o número da conta para a transferência?");
                            conta.setNumero(int.Parse(Console.ReadLine()));
                            Console.WriteLine("Qual o valor da sua para a transferência?");
                            double valor = double.Parse(Console.ReadLine());
                            cp.transferir(valor, new ContaCorrente());
                            Console.WriteLine("A transferência foi realizada!");
                        }
                        else if (opcao == 4)
                        {
                            Console.WriteLine(cp.consultarSaldo());
                        }
                        else if (opcao == 5)
                        {
                            Console.WriteLine("Qual é a sua taxa em %?");
                            double taxa = double.Parse(Console.ReadLine());
                            cp.calcularRendimento(taxa);
                            Console.WriteLine("Calculado com sucesso!");
                        }
                        else
                        {
                            break;
                        }
                        Console.ReadKey();
                    }
                    while (op != 0);
                }
                else
                {
                    Environment.Exit(0);
                }
                Console.ReadKey();
            }
            while (op != 0);
        }
    }
}
