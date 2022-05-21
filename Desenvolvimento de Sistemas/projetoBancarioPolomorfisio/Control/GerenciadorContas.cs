using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioPolimorfismo
{
    class GerenciadorContas
    {
        //atributo 
        private double saldoTotal;

        //get e set
        public double getSaldoTotal()
        {
            return saldoTotal;
        }

        public void setSaldoTotal(double saldoTotal)
        {
            this.saldoTotal=saldoTotal;
        }

        // 2 contrutores
        public GerenciadorContas()
        {
            saldoTotal = 0;
        }
        public GerenciadorContas(double saldoTotal)
        {
            this.saldoTotal = saldoTotal;
        }

        //métodos
        public void totalizarSaldos(Conta conta)
        {
            saldoTotal += conta.getSaldo();
        }
    }
}
