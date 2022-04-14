using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace viagem
{
    internal class Percurso
    {
        private double kmPercorrida;
        private double valorCombustivel;
        private double valorPedagio;

        public string listarPercurso()
        {
            return "Quilômetro percorrido é " + kmPercorrida + "\nValor do combustível é " + valorCombustivel + "\nValor do pedágio é " + valorPedagio;
        }
        
        public Percurso()
        {
            kmPercorrida = 0;
            valorCombustivel = 0;
            valorPedagio = 0;
        }
        public Percurso(double KmPercorrido, double ValorCombustivel, double ValorPedagio)
        {
            kmPercorrida = KmPercorrido;
            valorCombustivel = ValorCombustivel;
            valorPedagio = ValorPedagio;

        }

        //get e set para km percorrida
        public double getKmPercorrida()
        {
            return kmPercorrida;
        }
        
        public void setKmPercorrida(double kmPercorrida)
        {
            this.kmPercorrida = kmPercorrida;
        }
        //get e set para valor do combustível
        public double getValorCombustivel()
        {
            return valorCombustivel;
        }

        public void setValorCombustivel(double valorCombustivel)
        {
            this.valorCombustivel = valorCombustivel;
        }

        //get e set para valor do pedágio
        public double getValorPedagio()
        {
            return valorPedagio;
        }

        public void setValorPedagio(double valorPegadio)
        {
            this.valorPedagio = valorPegadio;
        }
    }
}
