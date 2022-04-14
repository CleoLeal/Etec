using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    class mediaNotas
    {
        static void Main(string[] args)
        {
            //programa para calcular a média 
            //ok, certo

            //declare um array double de 4 posições chamado notas.
            double[] notas = new double[4];
            //faça um for para recever as notas:
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite a " + (i + 1) + " nota");
                notas[i] = double.Parse(Console.ReadLine());
            }
            //calcule a media
            double media = (notas[0] + notas[1] + notas[2] + notas[3] / 4);
            //exiva as notas e a media
            Console.WriteLine("As notas foram " + notas[0] + "," + notas[1] + "," + notas[2] + "," + notas[3] + "\nMédia= " + media);
            Console.ReadKey();
        }
    }
}
