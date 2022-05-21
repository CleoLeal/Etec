using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancarioPolimorfismo
{
    class ContaCorrente:Conta
    {
        //atributo
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

        // 3 contrutores
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
        public ContaCorrente(double limiteEspecial)
        {
            this.limiteEspecial=limiteEspecial;
        }

        //métodos

        /*como na classe Conta existe um método abstract
        e a gente faz uma herança com a ContaCorrente:Conta
        precisa ter o atualizarSaldos() da Conta.*/
        public override void atualizarSaldos()
        {
            if (getSaldo() < 0)
            {
                setSaldo(getSaldo() + getSaldo() * 0.08);
                Console.WriteLine("O seu saldo é: " + getSaldo());
            }
        }

        /*override siginifica estar sobrescrevendo
        o método debitar da superClasse*/
        public override string debitar(double valor)
        {
            if(valor <= getSaldo() + limiteEspecial)
            {
                setSaldo(getSaldo()-valor);
                return "Débito efetuado com sucesso";
            }
            return "Saldo insuficiente";
        }

    }
}
