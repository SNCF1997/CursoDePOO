using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    internal class Circulo : FiguraGeometrica
    {
        public override double CalcArea(double valor1, double valor2)
        {
            double area = valor1 * Math.Pow(valor2,2);
            return(area);
        }
        public override double CalcPerimetro(double valor1, double valor2)
        {
            double perimetro = valor1 * valor2 * 2;
            return(perimetro);
        }
    }
}
