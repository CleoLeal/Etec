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

        /* O virtual significa que eu (eu como conta) permita 
         que as minhas subclasses sobrescrevam esse método */
        public virtual string debitar (double valor)
        {
            if(saldo >= valor)
            {
                saldo -= valor;
                return "Débito efetuado com sucesso";
            }
            return "Saldo insuficiente";
        }

        //método abstract
        public abstract void atualizarSaldos();
    }
}
