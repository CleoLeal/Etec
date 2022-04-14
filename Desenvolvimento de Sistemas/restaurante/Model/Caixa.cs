using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurante
{
    internal class Caixa
    {
        
        public string totalizarComanda(Comanda p)
        {
            p.setValorTotal(p.getValorConsumo()+p.getValorEstacionamento()+p.getValorCouvert()-p.getValorDescontoPromocional());
            return p.getValorTotal() + "\nTotal= " + p.getValorTotal();
            
        }
    }
}
