using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            Console.WriteLine("Informe o lado 1");
            triangulo.lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado 2");
            triangulo.lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o lado 3");
            triangulo.lado3 = double.Parse(Console.ReadLine());
            if (triangulo.IsTriangle())
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Classificação é: " + triangulo.classificacao);
                Console.WriteLine("O lado 1 é: " + triangulo.lado1);
                Console.WriteLine("O lado 2 é: " + triangulo.lado2);
                Console.WriteLine("O lado 3 é: " + triangulo.lado3);
                Console.WriteLine("O perímetro é: " + triangulo.perimetro);
                Console.WriteLine("A área é: " + triangulo.area);
                Console.WriteLine("----------------------------------------------");
            }
            else
            {
                Console.WriteLine("Os lados informados não formam um triângulo");
            }
            Console.ReadKey();
        }
    }
}
