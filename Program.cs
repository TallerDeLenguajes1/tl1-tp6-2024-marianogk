// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese una cadena:");
string cadena = Console.ReadLine();

// Longitud

Console.WriteLine("\nLongitud de la cadena '" + cadena + "': " + cadena.Length);

// Concatenar

Console.WriteLine("\nIngrese otra cadena:");
string cadena2 = Console.ReadLine();
string concat = cadena + cadena2;
Console.WriteLine("\nCadenas concatenadas: " + concat);

// Extraer subcadena

string subcadena = cadena2.Substring(1, 3);
Console.WriteLine("\nSubcadena: " + subcadena);

// Operaciones

Console.WriteLine("\nIngrese dos numeros:");
float n1 = float.Parse(Console.ReadLine());
float n2 = float.Parse(Console.ReadLine());

// Suma
float suma = n1 + n2;
Console.WriteLine("\nSuma de " + n1.ToString() + " + " + n2.ToString() + " = " + suma.ToString());

// Resta
float resta = n1 - n2;
Console.WriteLine("\nResta de " + n1.ToString() + " - " + n2.ToString() + " = " + resta.ToString());

// Multiplicacion
float multi = n1 * n2;
Console.WriteLine("\nMultiplicacion de " + n1.ToString() + " * " + n2.ToString() + " = "  + multi.ToString());

// Division
if (n2 != 0)
{
    float divi = n1 / n2;
    Console.WriteLine("\nDivision de " + n1.ToString() + " / " + n2.ToString() + " = " + divi.ToString());
} else
{
    Console.WriteLine("\nNo se puede dividir en 0");
}

// Recorrer cadena

Console.WriteLine("\nLetras: ");
foreach (var letra in cadena)
{
    Console.WriteLine(letra);
}

// Buscar palabra

Console.WriteLine("\nIngrese la palabra a buscar:");
string busqueda = Console.ReadLine();
cadena = cadena.ToLower();
busqueda = busqueda.ToLower();
// Divido la cadena por espacios
string[] palabras = cadena.Split(' ');
int encuentra = 0;

// Busco la palabra, si la encuentra, la variable toma el valor 1
foreach (var pal in palabras)
{
    if (pal == busqueda)
    {
        encuentra = 1;
    }

}

// Muestro el mensaje
if (encuentra == 1)
{
    Console.WriteLine("\nLa palabra se encuentra en la cadena");
}
else
{
    Console.WriteLine("\nNO se encuentra la palabra");
}

// Mayusculas y Minusculas

cadena = cadena.ToUpper();
Console.WriteLine("\nCadena en mayusculas: "+cadena);

cadena = cadena.ToLower();
Console.WriteLine("\nCadena en minusculas: "+cadena);

// Cadena separada por caracteres

Console.WriteLine("\nIngrese una cadena separada por comas:");
string cadenaSep = Console.ReadLine();
string[] separada = cadenaSep.Split(',');

foreach (var l in separada)
{
    Console.Write(l + " ");
}

// Ecuacion

Console.WriteLine("\nIngrese una ecuacion:");
string ecuacion = Console.ReadLine();
string[] ecuacionS;
char operador;
float resultado=0;

ecuacionS = ecuacion.Split('+', '-', '*', '/');

// Obtengo los 2 numeros de la ecuacion
float nro1 = float.Parse(ecuacionS[0]);
float nro2 = float.Parse(ecuacionS[1]);

// Obtengo el operador, determinando la longitud del primer numero, despues de este sigue el operador
operador = ecuacion[ecuacionS[0].Length];


switch (operador)
{
    case '+':
        resultado = nro1 + nro2;
        break;

    case '-':
        resultado = nro1 - nro2;
        break;

    case '*':
        resultado = nro1 * nro2;
        break;

    case '/':
        resultado = nro1 / nro2;
        break;

    default:
        Console.WriteLine("Ecuacion no valida");
        break;
}

Console.WriteLine("\nEl resultado es: " + resultado);