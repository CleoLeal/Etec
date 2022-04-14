using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoTriangulo
{
    class Triangulo
    {
        public double lado1;
        public double lado2;
        public double lado3;
        public string classificacao;
        public double perimetro;
        public double area;

        
        public Triangulo()
        {
            lado1 = 0;
            lado2 = 0;
            lado3 = 0;
            classificacao = "";
            perimetro = 0;
            area = 0;
        }
        public Triangulo(double Lado1, double Lado2, double Lado3, string Classificacao, double Perimetro, double Area)
        {
            lado1= Lado1;
            lado2 = Lado2;
            lado3 = Lado3;
            classificacao = Classificacao;
            perimetro = Perimetro;
            area = Area;
        }
        public Triangulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public bool IsTriangle()
        {
            
            if (lado1 < lado2 + lado3 && lado2 < lado1+lado3 && lado3 < lado1+lado2)
            {
                Classificar();
                CalcularArea();
                return true;
            }
            return false;
        }
        public void CalcularPerimetro()
        {
            perimetro = lado1 + lado2 + lado3;
        }
        public void Classificar()
        {
            if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
            {
                classificacao = "Triangulo equilatero";
            }
            else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
            {
                classificacao = "Triangulo Escaleno";
            }
            else
            {
                classificacao = "Triangulo isósceles";
            }
        }
        public void CalcularArea()
        {
            CalcularPerimetro();
            double sp = perimetro / 2;
            area = Math.Sqrt(sp * (sp - lado1) * (sp - lado2) * (sp - lado3));
        }
    }
}
