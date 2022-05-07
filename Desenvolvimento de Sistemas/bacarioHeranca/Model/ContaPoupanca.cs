using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancarioHeranca.Model
{
    internal class ContaPoupanca: Conta
    {
        private double reajusteMensal;

        
        //get e set
        public double getReajusteMensal()
        {
            return reajusteMensal;
        }
        public void setReajusteMensal(double reajusteMensal)
        {
            this.reajusteMensal = reajusteMensal;
        }

        //dois construtores
        public ContaPoupanca():base()
        {
            reajusteMensal = 0;
        }
        public ContaPoupanca(double saldo, int numero, double reajusteMensal):base(saldo,numero)
        {
            this.reajusteMensal=reajusteMensal;
        }

        //método calcular rendimento
        public void calcularRendimento(double taxa)
        {
            if(taxa > 0 && getSaldo() > 0)
            {
                //o reajuste mensal é o saldo da pessoa vezes a taxa do banco
                reajusteMensal = getSaldo() * taxa;
                atualizarSaldo();
            }
        }

        //método atualizar saldo
        private void atualizarSaldo()
        {
            setSaldo(getSaldo() + reajusteMensal);
        }

        public override string consultarSaldo()
        {
            return base.consultarSaldo() + "\nReajuste mensal: " + reajusteMensal;
        }
    }
}
