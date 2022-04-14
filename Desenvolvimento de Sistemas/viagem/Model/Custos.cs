using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viagem
{
    class Custos
    {
        double totalPercurso;
        public string calcularViagem(Percurso p)
        {
            totalPercurso = p.getKmPercorrida() * p.getValorCombustivel() * p.getValorPedagio();
            return p.listarPercurso() + "\nTotal Percurso= " + totalPercurso;
        }
    }
}
