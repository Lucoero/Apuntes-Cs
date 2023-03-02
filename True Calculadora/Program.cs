using System.Collections.Specialized;

namespace True_Calculadora
{
    internal class Program
    {
        static double Exponencial(double a, int b) // Siendo a la base, y b el exponente.  Ya trataremos con decimales más adelante
        {
            double result = a;

            if (b == 0)
            {
                return 1;
            }

            for (int i = 1; i < b; i++)
            {
                result = result * a;
            }

            return result;
        }
        static void Main(string[] args)
        {
            // Declaración de variables
            bool Cierre = false, ErrorOperador = false;
            double num1, num2, resultado = 0; // Por alguna razón debo darle un valor por defecto a resultado, porque aparece en el if del final. 
            string operador, PosibleSalida;

            // Introducción en consola
            Console.WriteLine("Bienvenido a Calcutrón5000, una calculadora nada eficiente que permite \nsumar, restar, multiplicar, dividir y elevar.");
            Console.WriteLine("A continuación te pediremos un número, un operador (+,-,*,/,**), y un segundo número.");
            Console.WriteLine("No puedes escribir fracciones. Lo siento");
            Console.WriteLine("No puedes escribir raíces ni fracciones, así que recuerda que el exponente debe ser un natural \n");
            Console.WriteLine("Cuando quieras cerrar la calculadora, escribe \"salir\" Como primer número \n");

            // Inicio de la calculadora
            while (!Cierre) 
            {
                // Toma de datos
                Console.Write("Dime el primer número: ");
                PosibleSalida = Console.ReadLine();
                if (PosibleSalida.ToLower() == "salir" || PosibleSalida.ToLower() == "exit")
                {
                    Cierre = true;
                }
                else
                {
                    num1 = Convert.ToDouble(PosibleSalida); // Ya hemos confirmado que el user no ha escrito "exit"
                    Console.Write("Dime el operador: ");
                    operador = Console.ReadLine();
                    Console.Write("Dime el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    // Proceso del operador
                    switch (operador)
                    {
                        case "+":
                            resultado = num1 + num2;
                            break;
                        case "-":
                            resultado = num1 - num2;
                            break;
                        case "*":
                            resultado = num1 * num2;
                            break;
                        case "**":
                            resultado = Exponencial(num1, Convert.ToInt32(num2));
                            break;
                        default:
                            ErrorOperador = true; 
                            break;
                    }

                    // Printear el resultado
                    if (ErrorOperador)
                    {
                        Console.WriteLine("Operador erróneo\n");
                        
                    } else
                    {
                        Console.WriteLine(resultado + "\n");
                    }
                }
            }

            // Cierre del programa
            Console.WriteLine("Hasta luego!");

        }      
    }
}