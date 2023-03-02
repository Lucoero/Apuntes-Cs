using System.Globalization;

namespace CalculadoraSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PROYECTO 1: CALCULADORA SIMPLE
            // Pedir por consola num1, operador, num2 y printear el resultado.
            // Siendo los operadores suma, resta, multiplicación y división.
            // En caso de dividir entre 0, devolver un error
            Console.WriteLine("Bienvenido a la calculadora más simple del mundo.\nSolo sabe sumar. Los decimales se escriben con coma. ");
            Console.Write("Dime el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture); // InvariantCulture permite al método Convert identificar los puntos 
                                                                                              // Como ubicación decimal. Que no esté por defecto me aterra. 
            Console.Write("Dime el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Resultado de " + num1+ " + " + num2 + ": " + (num1 + num2));
        }
    }
}