using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            Comanda controleMesa = new Comanda();
            Caixa caixa=new Caixa();

            int opcao = 0;
            double consumo = 0;
            double estacionamento = 0;
            double couvert = 0;
            int id = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("1- Lançar gastos\n2- Verificar promoção\n3- Fechar a mesa\n4- Listar comanda\n0- Sair");
                opcao = int.Parse(Console.ReadLine());
                if (opcao == 0)
                {
                    Environment.Exit(0);
                }
                else if (opcao == 1)
                {

                    Console.WriteLine("Comanda:");
                    id = int.Parse(Console.ReadLine());
                    controleMesa = new Comanda(id);

                    Console.WriteLine("Consumo:");
                    consumo = double.Parse(Console.ReadLine());
                    controleMesa.setValorConsumo(consumo);

                    Console.WriteLine("Estacionamento");
                    estacionamento = double.Parse(Console.ReadLine());
                    controleMesa.setValorEstacionamento(estacionamento);

                    Console.WriteLine("Couvert:");
                    couvert = double.Parse(Console.ReadLine());
                    controleMesa.setValorCouvert(couvert);

                   

                    Console.WriteLine(caixa.totalizarComanda(controleMesa));

                }
                else if (opcao==2)
                {
                    if (controleMesa.verificarPromocao())
                    {
                        Console.WriteLine("Desconto Promocional de 10%:" + controleMesa.getValorDescontoPromocional());
                    }
                    else
                    {
                        Console.WriteLine("Valor não atingiu o limite para o desconto promocional.");
                    }
                    
                }
                else if (opcao == 3)
                {
                    Console.WriteLine(caixa.totalizarComanda(controleMesa));
                }
                else if (opcao == 4)
                {
                    Console.WriteLine(controleMesa.listarComanda());
                }
                Console.ReadKey();
            }
            while (opcao > 0);
        }
    }
}
