using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancario
{
    class Conta
    {
        public double saldo;
        public int numero;
        public void depositar(double valor)
        {            
            if (valor > 0)
            {
                saldo = saldo + valor;
            }
        }
        public bool sacar(double valor)
        {
            if (valor > 0 && valor<=saldo)
            {
                saldo = saldo - valor;
                return true;
            }
            return false;
        }
        public string ConsultarSaldo()
        {
            return saldo.ToString();
        }
        public void transferir(double valor, Conta destino)
        {
            if(valor>0 && sacar(valor))
            {
                destino.depositar(valor);
            }
        }
    }
}
