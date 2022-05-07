using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancarioHeranca.Model
{
    internal class Conta
    {
        private double saldo;
        private int numero;

        //get e set
        public double getSaldo()
        {
            return saldo;
        }
        public void setSaldo(double saldo)
        {
            this.saldo=saldo;
        }

        public int getNumero()
        {
            return numero;
        }
        public void setNumero(int numero)
        {
            this.numero = numero;
        }

        //três construtores
        public Conta()
        {
            this.saldo = 0;
            this.numero = 0;
        }

        public Conta(double Saldo, int Numero)
        {
            this.saldo = Saldo;
            this.numero= Numero;
        }

        public Conta(int Numero)
        {
            this.saldo = 0;
            this.numero = Numero;
        }
        
        //método depositar
        public void depositar(double valor)
        {
            if (valor > 0)
            {
                //este valor soma  saldo=saldo+valor
                this.saldo+=valor;
            }
        }

        public bool sacar(double valor)
        {
            if (valor>0 && valor<=saldo)
            {
                 //este valor subtrai saldo=saldo+valor
                saldo-=valor;
                return true;
            }            
            return false;
        }

        public void transferir(double valor, Conta destino)
        {
            if (sacar(valor))
            {
                destino.depositar(valor);
            }
        }

        public virtual string consultarSaldo()
        {
            return "Saldo da conta: " + saldo;
        }
    }
}
