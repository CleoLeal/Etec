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

        //método calcular rendimento
        public void calcularRendimento(double taxa)
        {
            if(taxa > 0)
            {
                setReajusteMensal(getSaldo() * taxa);
                atualizarSaldo();
            }
        }

        //método atualizar saldo
        private void atualizarSaldo()
        {
            setSaldo(getSaldo() + getReajusteMensal());
        }

        public override string consultarSaldo()
        {
            return base.consultarSaldo() + "\nReajuste mensal: " + reajusteMensal;
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

        //get e set
        public double getReajusteMensal()
        {
            return reajusteMensal;
        }
        public void setReajusteMensal(double reajusteMensal)
        {
            this.reajusteMensal = reajusteMensal;
        }

    }
}
