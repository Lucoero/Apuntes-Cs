namespace Funciones_asincronas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static async bool Wait(int seconds)
            {
                await Task.Delay(seconds);
                return true; 
            }
            Console.Write("Dime cuantos segundos quieres esperar: ");
            try
            {
                Wait(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Listo!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}