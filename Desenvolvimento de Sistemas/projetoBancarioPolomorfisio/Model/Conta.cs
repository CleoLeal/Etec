using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioPolimorfismo
{
    abstract class Conta
    {
        private double saldo;

        //método abstrato
        public abstract void atualizarSaldos();

        //get e set

        public double getSaldo()
        {
            return saldo;
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        //métodos
        public void creditar (double valor)
        {
            saldo += valor;
        }

        public virtual bool debitar (double valor)
        {
            if(valor<=saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }
    }
}
