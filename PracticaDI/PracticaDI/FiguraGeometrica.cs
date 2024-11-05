using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaLCP
{
    public class FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public virtual double CalcularArea()
        {
            return Base * Altura;
        }
    } 
    
    public class Cuadrado : FiguraGeometrica
    {
        public override double CalcularArea()
        {
            return Base * Altura; 
        }
    }  
    
    public class Rectangulo : FiguraGeometrica
    {
        public override double CalcularArea()
        {
            return Base * Altura; 
        }
    }


    //Refactorizando

    public class FiguraGeometricaR
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public virtual double CalcularArea()
        {
            return Base * Altura;
        }
    }

    public class CuadradoR : FiguraGeometricaR
    {
        public double Lado { get; set; }

        public override double CalcularArea()
        {
            return Lado * Lado; 
        }
    }

    public class RectanguloR : FiguraGeometricaR
    {
        public override double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
