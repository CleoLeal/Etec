using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioPolimorfismo
{
    class ContaPoupanca : Conta
    {
        //atributos
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

        // 2 contrutores
        public ContaPoupanca()
        {
            reajusteMensal = 0;
            setSaldo(0);
        }
        public ContaPoupanca(double reajusteMensal, double saldo)
        {
            this.reajusteMensal = reajusteMensal;
            setSaldo(saldo);
        }

        public override void atualizarSaldos()
        {
            throw new NotImplementedException();
        }

        public string atualizarSaldos(double reajuste)
        {
            if(getSaldo() > 0)
            {
                reajusteMensal = (getSaldo() * reajuste) / 100;
                setSaldo(getSaldo() + reajusteMensal);
                return "Saldo atual: " + getSaldo();
            }
            return "Saldo atual: " + getSaldo();
            
        }
    }
}
