using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioPolimorfismo
{
    class ContaCorrente:Conta
    {
        private double limiteEspecial;

        //get e set
        public double getLimiteEspecial()
        {
            return limiteEspecial;
        }
        public void setLimiteEspecial(double limiteEsepecial)
        {
            this.limiteEspecial = limiteEsepecial;
        }

        // 2 contrutores
        public ContaCorrente()
        {
            limiteEspecial = 0;
            setSaldo(0);
        }
        public ContaCorrente(double limiteEspecial, double saldo)
        {
            this.limiteEspecial = limiteEspecial;
            setSaldo(saldo);
        }

        //métodos
        public override void atualizarSaldos()
        {
            if(getSaldo()<0)
            {
                setSaldo(getSaldo() * 1.08);
                Console.WriteLine("O seu saldo é: " + getSaldo());
            }
        }

        public override void debitar(double valor)
        {
            if(getSaldo() + getLimiteEspecial()>valor)
            {
                setSaldo(getSaldo()-valor);
            }
        }
    }
}
