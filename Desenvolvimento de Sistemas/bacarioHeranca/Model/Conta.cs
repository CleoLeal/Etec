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

        //método depositar
        public void depositar(double valor)
        {
            if (valor > 0)
            {
                setSaldo(getSaldo() + (valor));
            }
        }

        public bool sacar(double valor)
        {
            if (getSaldo()>=valor && getSaldo()>0)
            {
                setSaldo(getSaldo() - (valor));
                return true;
            }            
            return false;
        }

        public void transferir(double valor, Conta destino)
        {
            if (sacar(valor) && valor>0)
            {
                destino.depositar(valor);
            }
            else
            {
                Console.WriteLine("Poor");
            }
        }

        public virtual string consultarSaldo()
        {
            return "Saldo da conta: " + getSaldo() + "\nNúmero da conta: "+ getNumero();
        }

        //três construtores
        public Conta()
        {
            saldo = 0;
            numero = 0;
        }

        public Conta(double Saldo, int Numero)
        {
            saldo = Saldo;
            numero= Numero;
        }

        public Conta(int Numero)
        {
            saldo = 0;
            numero = Numero;
        }

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
    }
}
