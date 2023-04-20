using System;
using System.Diagnostics;
using System.IO; // Me permite leer directamente del disco

// Ejemplo no asíncrono
//Stopwatch stopwatch = new Stopwatch();
//stopwatch.Start();
//var lines = File.ReadAllLines("E:\\Proyectos C\\Apuntes-Cs\\Funciones_asincronas\\Leeme.txt"); 
//foreach (var line in lines)
//{
//    Console.WriteLine(line);
//}
//TimeSpan ts = stopwatch.Elapsed;
////Console.WriteLine("Time elapsed: {0}", ts);
//// Ejemplo asíncrono (poco eficiente porque invade el procesador con .Result)
//stopwatch = new Stopwatch();
//stopwatch.Start();
//// Creo la tarea
//var fileReadTask = File.ReadAllLinesAsync("E:\\Proyectos C\\Apuntes-Cs\\Funciones_asincronas\\Leeme.txt"); // Ejemplo de una funcion asincrona. Todas van a acabar con Async.
//// Compruebo el progreso de la tarea (nulo)
//Console.WriteLine(fileReadTask.Status);
//// Informo al procesador de que hay tiempo libre
//Thread.Sleep(1); // En milisegundos. Este proceso es tan rápido que se podría completar entre lineas (prueba a comentar esta linea)
//Console.WriteLine(fileReadTask.Status);
//Console.WriteLine(fileReadTask.Status);
//lines = fileReadTask.Result;
//foreach (var line in lines)
//{
//    Console.WriteLine(line);
//}
//ts = stopwatch.Elapsed;
//// Console.WriteLine("Time elapsed: {0}", ts);

//// Ejemplo asíncrono (eficiente por el uso de .ContinueWith)
//stopwatch = new Stopwatch();
//stopwatch.Start();
//File.ReadAllLinesAsync("E:\\Proyectos C\\Apuntes-Cs\\Funciones_asincronas\\Leeme.txt").ContinueWith(t =>
//{
//    if (t.IsFaulted) // Manejo de excepciones manual
//    {
//        Console.WriteLine(t.Exception);
//        return;
//    }
//    // Aquí entraré al terminar la tarea
//    foreach (var line in t.Result)
//    {
//        Console.WriteLine(line);
//    }
//}); // La tarea está en t, y nos meteremos en el continue with cuando se termine
//ts = stopwatch.Elapsed;
//// Console.WriteLine("Time elapsed: {0}", ts);
//Console.ReadKey();
/* 
 * El haber metido codigo despues del ContinueWith da unos milisegundos en los que completar la tarea
 * De no haberlo puesto, el script podría finalizar sin hacer el ContinueWith
*/

/* FORMA MAS EFICIENTE Y BONITA: TASK, AWAIT y async
 * Task indica que lo que devuelve es un objeto task
 * Await se usa para parar esa funcion hasta tener la tarea hecha, pero sin priorizarla
 * async indica que la funcion es asíncrona, permitiendo el uso de await.
*/
static async Task ReadFileAsync(string file)
{
    var lines = await File.ReadAllLinesAsync(file);
    foreach (var line in lines)
    {
        Console.WriteLine(line);
    }
}
await ReadFileAsync("E:\\Proyectos C\\Apuntes-Cs\\Funciones_asincronas\\Leeme.txt");
Console.ReadKey();

static async Task<int> PidoRedAsync()
{
    // Simulamos la llamada
    await Task.Delay(150);
    var result = 7;
    return result;
}
var NetworkResult = await PidoRedAsync();
Console.ReadKey(); 