using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancarioHeranca.Model
{
    internal class ContaCorrente: Conta
    {
        private double limite;
        private double jurosChequeEspecial;

        //get e set
        public double getLimite()
        {
            return limite;
        }
        public void setLimite(double limite)
        {
            this.limite=limite;
        }

        public double getJurosChequesEspecial()
        {
            return jurosChequeEspecial;
        }
        public void setJurosChequesEspecial(double jurosChequeEspecial)
        {
            this.jurosChequeEspecial = jurosChequeEspecial;
        }

           //três construtores
        public ContaCorrente():base()
        {
            limite = 0;
            jurosChequeEspecial = 0;
        }
        public ContaCorrente(int numero, double saldo, double limite, double jurosChequesEspecial):base(saldo,numero)
        {
            this.limite = limite;
            this.jurosChequeEspecial=jurosChequesEspecial;
        }
        public ContaCorrente(double limite):base()
        {
            this.limite=limite;
            jurosChequeEspecialEspecial=0;
        }

        //método sacar
        public override bool sacar(double valor)
        {
            if (valor>0 && valor <= getSaldo() + limite)
            {
                setSaldo(getSaldo() - valor);
                return true;
            }
            return false;
        }

        //método calcular juros
        public void calcularJuros(double taxa)
        {
            if(getSaldo() < 0 )
            {
                //o juros do cheque especial é o saldo vezes a taxa. depois armazena no setSaldo a soma do saldo e do juros cheque especial
                jurosChequeEspecial = getSaldo() * taxa;
                setSaldo(getSaldo() + jurosChequeEspecial);
            }
        }

        public override string consultarSaldo()
        {
            return base.consultarSaldo() + "\nLimite: " + getLimite() + "\nJuros do cheque especial: " + getJurosChequesEspecial(); 
        }
    }
}
