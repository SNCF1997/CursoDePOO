using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    internal class Rectangulo:FiguraGeometrica
    {
        public override double CalcArea(double valor1, double valor2)
        {
            double area = valor1 * valor2;
            return (area);
        }
        public override double CalcPerimetro(double valor1, double valor2)
        {
            double perimetro = 2* valor1 + 2* valor2;

            return(perimetro);
        }
    }
}
