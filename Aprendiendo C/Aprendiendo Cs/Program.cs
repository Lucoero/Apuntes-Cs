// See https://aka.ms/new-console-template for more information

using Aprendiendo_Cs;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello World!");
// Declaración de Variables
string MyName;
MyName = "Pepe";

//Tipos de variable
string MasDeUnCaracter = "Hola";
char Un_Solo_Caracter = 'a'; // IMPORTANTE: SI ESCRIBES UN CHAR CON "" LO IDENTIFICA COMO UN STR
int UnNatural = 5;
float UnDecimalPocoPreciso = 5.1f; // Precision 6-9 digitos
double UnDecimalAlgoPreciso = 5.15d; // Precision 15-17 digitos
decimal UnDecimalSuperPreciso = 5.1542256214m; // Precision 28-29 digitos
bool IsTrue = true;
string str1, str2, str3; // Podemos enunciar la clase de varias variables a la vez. 
Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));

// Uso de Strings
Console.WriteLine(MyName);
Console.WriteLine(" ".Length);
Console.WriteLine(MasDeUnCaracter[MasDeUnCaracter.Length - 1]); // No se pueden usar negativos en los índices
Console.WriteLine("Indice de \'Caracola\' en \'Hola Caracola\': " + "Hola Caracola".IndexOf("Caracola")); // El índice que marca es el que coincide con
MasDeUnCaracter.Substring(1);                                                                             // EL PRIMER CARACTER QUE COINCIDA
Console.WriteLine(MasDeUnCaracter); // Se puede ver que substring COPIA, NO CORTA.
Console.WriteLine(String.Format("Buenas, me llamo {0}",MyName)); // Uso de .format en Cs.

// Estructura dentro-fuera
Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));
// Console.WriteLine("Dime tu nombre: ");
// Console.WriteLine("Hola, " + Console.ReadLine());

// Uso de Numeros
Console.WriteLine("5/2 = " + 5 / 2); // Trabajar con int devuelve ints
Console.WriteLine("5/2.0 = " + 5 / 2.0); // Pero si uno es un double, devuelve double
Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));

//Uso de Arrays
int[] MyArray = { 1, 2, 3, 4 };
Console.WriteLine("El primer número es el " + MyArray[0]); // Misma indentación de siempre
MyArray[0] = 10; // Puedo modificar el array siempre y cuando no aumente el tamaño ni cambie el tipo de dato.
Console.WriteLine("Ahora el primer número es el " + MyArray[0]);
int[] MyArray2 = MyArray;
MyArray2[0] = 5;
Console.WriteLine("Ahora el primer número en MyArray2 es el " + MyArray2[0]);
Console.WriteLine("Ahora el primer número en MyArray es el " + MyArray2[0]); // Se puede ver que al igualarnos NO se hace una copia,
                                                                             // sino que se copia el directorio donde se encuentra MyArray
int[] ArrayVacio = new int[10]; // He creado un array de 0s con 10 huecos.

int[,] Array2d =
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9 },
}; // Los arrays del interior deben tener el mismo tamaño entre ellos.
Console.WriteLine("Ejemplo de array 2d: " + Array2d); // Se puede ver que no se puede imprimir un array tal cual.

int[,,] Array3d =
{
    {{1,2,3 }, {4,5,6 } },
    {{7,8,9 }, {10,11,12}}
}; // Ejemplo array 3d.
Console.WriteLine("El número cuatro en el array3d está en [0,1,0]: " + Array3d[0,1,0]); // No vale colocar los índices por separado ([1][0][1])

int[,,] Array3dVacio = new int[3,4,5]; // 1 Array hecho de 3 arrays a su vez hechos por 4 arrays cada uno de 5 elementods. 
// Console.WriteLine("My Array vacío de int es: " + Array.ToString(ArrayVacio)); Esto no funciona, ni tampoco printear tal cual ArrayVacio
//int[] SumaArrays = MyArray2 + MyArray;
//Console.WriteLine(SumaArrays)s
Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));

// Métodos
static void SayHi(string name) // No importa donde ponga la función, aunque por convenio debería estar arriba del todo del programa.
{
    Console.WriteLine("Hi, " + name);
}

SayHi("Lucas"); // Con la plantilla de instrucciones nivel superior las funciones se escriben "dentro" de Main (él solo las separa)
static double cube(double number) // Ejemplo de función con return. Void se cambia por el tipo de dato a devolver.
{
    return (number * number * number);
}
Console.WriteLine(cube(2));
Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));

// Condicionales
bool Llueve = true;
bool TengoParaguas = false;
if (Llueve && TengoParaguas) // Ejemplo de condicional con else if. 
{
    Console.WriteLine("Voy a salir a dar una vuelta");
} else if (!Llueve && TengoParaguas) // && = and; || = or; ! = not 
{
    Console.WriteLine("Bueno, usaré mi paraguas como parasol");
} else if (Llueve && !TengoParaguas)
{
    Console.WriteLine("Si salgo me voy a empapar");
}
Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));

//Switch statements
int dayNum = 0;
string day;

switch (dayNum) // Ejemplo de switch statement. 
{
    case 0:
        day = "Monday";
        break;
    case 1:
        day = "Tuesday";
        break;
    case 3:
        day = "Wednesday";
        break;
    //...
    default:
        day = "Invalid day number";
        break;
}
Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));
//Por cierto, aqui hay un ejemplo de comentar un bloque entero. 
/*
En un lugar de la Mancha, 
de cuyo nombre no quiero acordarme, 
no ha mucho tiempo que vivía un hidalgo de los de lanza en astillero, 
adarga antigua, rocín flaco y galgo corredor. 
*/


//While loops
int condition = 0;
while (condition <= 10) // Ejemplo while
{
    Console.WriteLine(condition);
    condition++; // Equivalente a sumarle 1
}
Console.WriteLine("Ya me voy del While");
do
{
    Console.WriteLine(condition);
    condition++;
} while (condition < 10); // En este caso, se ejecutará primero una vez y luego comprobará la condición.
Console.WriteLine("Ya me voy del While");
condition = 9;
do
{
    Console.WriteLine(condition);
    condition++;
} while (condition < 10); // Al pasar la primera iteración, el programa vuelve a comprobar la condición antes de ejecutarse (como siempre)
Console.WriteLine("Ya me voy del While");

Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));

// Bucle for 

for (int i = 0; i <= 10; i = i + 5) // Ejemplo de bucle for.
{
    Console.WriteLine(i);
}
Console.WriteLine("Me voy del for");
string[] Nombres = { "Pepe", "Jacinto", "Arturo", "Don Felipe II" };
for (int i = 0; i < Nombres.Length; i++)
{
    Console.WriteLine(Nombres[i]);
}
Console.WriteLine("Me voy del for");

Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));

// Manejo de excepciones
int num1, num2;

try
{
    /*
    Console.WriteLine("Dime un número: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Dime un segundo número: ");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("La división del primer número entre el segundo es igual a " + num1 / num2);
    */
}
/* Si capturo en general, luego no puedo especificar en otros catch. 
catch (Exception x)
{
    Console.WriteLine(x.Message); // Cada error tiene un metodo Message asociado
}
*/
catch (DivideByZeroException o)
{
    Console.WriteLine("A ver, sabes que dividir entre cero está regular.");
}
catch (FormatException d)
{
    Console.WriteLine("Macho, te he pedido un integer...");
}
Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));

// Creación de Objetos
Fraccion MyFraccion = new Fraccion("1/2"); 
//MyFraccion.imagen = "1/2";  //Cambiar los atributos
//MyFraccion.valor = 0.5;
Console.WriteLine("El aspecto de MyFraccion es: " + MyFraccion.imagen);
Console.WriteLine("El valor de MyFraccion es: " + MyFraccion.valor);

Fraccion Frac1 = new Fraccion("5/124");
Fraccion Frac2 = new Fraccion("3/310");

Fraccion Frac3 = Fraccion.Sum(Frac1,Frac2);
Console.WriteLine(Frac1.imagen + " + " + Frac2.imagen + " = " + Frac3.imagen);
Console.WriteLine(Frac1.valor + " + " + Frac2.valor + " = " + Frac3.valor);

Console.WriteLine(String.Concat(Enumerable.Repeat("-", 20)));
// Getters and Setters
Console.Write("Meteme una contraseña (si me haces 1234 me voy a enfadar): ");
Contraseñas MyPass = new Contraseñas(Console.ReadLine());
Console.WriteLine(MyPass.AdministrarContraseña);

// Console.WriteLine("Escribe cualquier cosa para terminar el programa"); // Forma de evitar cerrar el programa de golpe
// Console.ReadLine();

