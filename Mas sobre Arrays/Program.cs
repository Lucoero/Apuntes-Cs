namespace Mas_sobre_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] myArray = {1, 2};
            int[] myArray2 = {3, 4};
            int[] myArray3 = new int[5];

            // Métodos (son estáticos)
            Console.WriteLine("En total myArray tiene " + myArray.Length + " elementos."); // Obtiene el numero total de elementos del array.
            Console.WriteLine(myArray.ToString()); // Hago un string que simula myArray

            // Copiar elementos
            Array.Clear(myArray, 1, myArray.Length-1); // Vacía el array desde el 1 hasta el final. 
            myArray2.CopyTo(myArray, 0); // He duplicado myArray2 de forma un poco bestia.
            int[] myArrayCloned = myArray3; // He clonado. Es decir, sus elementos comparten el mismo directorio de memoria. 
    }
}