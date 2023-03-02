using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendiendo_Cs
{
    internal class Fraccion
    {
        public string imagen;
        public double valor;
        /*
        public Fraccion() // Constructor
        {
            image = "0"; // Asigno valores por defecto
            valor = 0;
        }
        */
        public Fraccion(string aImagen)
        {
            imagen = aImagen;
            if (aImagen == "0")
            {
                valor = 0;
            } else
            {
                valor = Convert.ToDouble(aImagen.Split("/")[0]) / Convert.ToDouble(aImagen.Split("/")[1]);
            }
            
        }
        
        // Creación de Métodos
        /*
        public Fraccion Sum (Fraccion fraccion2)
        {
            double ValorFinal;
            string ImagenFinal;
            int Denominador1, Denominador2, Numerador1, Numerador2, DenominadorFinal, NumeradorFinal,Minimo;
            Fraccion FraccionFinal = new Fraccion("0",0);

            ValorFinal = this.valor + fraccion2.valor;
 
            Denominador1 = Convert.ToInt32(this.imagen.Split("/")[1]);
            Numerador1 = Convert.ToInt32(this.imagen.Split("/")[0]);

            Denominador2 = Convert.ToInt32(fraccion2.imagen.Split("/")[1]);
            Numerador2 = Convert.ToInt32(fraccion2.imagen.Split("/")[0]);
            
            DenominadorFinal = Denominador1 * Denominador2; // De momento voy a sumar, luego ya miro si es simplificable
            NumeradorFinal = Numerador1 * Denominador2 + Numerador2 * Denominador1;
            Console.WriteLine( " Resultado sin simplificar: " + NumeradorFinal + "/" + DenominadorFinal);

            Minimo = Math.Min(DenominadorFinal, NumeradorFinal); // Voy a buscar los múltiplos del numero más pequeño
            for (int i = Convert.ToInt32(Math.Ceiling(Minimo/2d)); i >= 2; i = i-1) // Lo busco empezando desde arriba.
                                                                                                      // Se que no va a tener múltiplos más grandes que la mitad de sí mismo
            {
                if (NumeradorFinal % i == 0 && DenominadorFinal % i == 0) // i divide a ambos
                {
                        NumeradorFinal = NumeradorFinal / i;
                        DenominadorFinal = DenominadorFinal / i;
                }
            }
        FraccionFinal.valor = ValorFinal;
        FraccionFinal.imagen = Convert.ToString(NumeradorFinal) + "/" + Convert.ToString(DenominadorFinal);
        return FraccionFinal;
        }
        */
        // Métodos estáticos
        public static Fraccion Sum(Fraccion fraccion1,Fraccion fraccion2)
        {
            double ValorFinal;
            string ImagenFinal;
            int Denominador1, Denominador2, Numerador1, Numerador2, DenominadorFinal, NumeradorFinal, Minimo;
            Fraccion FraccionFinal = new Fraccion("0");

            ValorFinal = fraccion1.valor + fraccion2.valor;

            Denominador1 = Convert.ToInt32(fraccion1.imagen.Split("/")[1]);
            Numerador1 = Convert.ToInt32(fraccion1.imagen.Split("/")[0]);

            Denominador2 = Convert.ToInt32(fraccion2.imagen.Split("/")[1]);
            Numerador2 = Convert.ToInt32(fraccion2.imagen.Split("/")[0]);

            DenominadorFinal = Denominador1 * Denominador2; // De momento voy a sumar, luego ya miro si es simplificable
            NumeradorFinal = Numerador1 * Denominador2 + Numerador2 * Denominador1;
            // Console.WriteLine(" Resultado sin simplificar: " + NumeradorFinal + "/" + DenominadorFinal);

            Minimo = Math.Min(DenominadorFinal, NumeradorFinal); // Voy a buscar los múltiplos del numero más pequeño
            for (int i = Convert.ToInt32(Math.Ceiling(Minimo / 2d)); i >= 2; i = i - 1) // Lo busco empezando desde arriba.
                                                                                        // Se que no va a tener múltiplos más grandes que la mitad de sí mismo
            {
                if (NumeradorFinal % i == 0 && DenominadorFinal % i == 0) // i divide a ambos
                {
                    NumeradorFinal = NumeradorFinal / i;
                    DenominadorFinal = DenominadorFinal / i;
                }
            }
            FraccionFinal.valor = ValorFinal;
            FraccionFinal.imagen = Convert.ToString(NumeradorFinal) + "/" + Convert.ToString(DenominadorFinal);
            return FraccionFinal;
        }
    }
}
