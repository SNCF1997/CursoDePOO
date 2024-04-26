using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    abstract class FiguraGeometrica
    {
        public double valor1 { get; set; }
        public double valor2 {  get; set; } 
        public virtual double CalcArea(double valor1, double valor2)
        {
            double area1 = valor1 + valor2;

            return(area1);
        }
        public virtual double CalcPerimetro(double valor1, double valor2)
        {
            double perimetro1 = valor1 + valor2;
            return(perimetro1);
        }

    }
}
