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

        //método sacar
        public bool sacar(double valor)
        {
            if (valor>0 && valor <= getSaldo() + getLimite())
            {
                setSaldo(getSaldo() - valor);
                if(getSaldo()==0)
                {
                    setLimite(getLimite() + getSaldo());
                }
                return true;
            }
            return false;
        }

        //método calcular juros
        public void calcularJuros(double taxa)
        {
            if(taxa > 0 )
            {
                setJurosChequesEspecial((getSaldo() * taxa)+ getSaldo());
            }
        }

        public override string consultarSaldo()
        {
            return base.consultarSaldo() + "\nLimite: " + getLimite() + "\nJuros do cheque especial: " + getJurosChequesEspecial(); 
        }

        //dois construtores
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
    }
}
