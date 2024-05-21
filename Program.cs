// See https://aka.ms/new-console-template for more information

// Ejercicio 3

Console.WriteLine("Ingrese un numero: ");

double nro = double.Parse(Console.ReadLine());

Console.WriteLine("Numero: " + nro);
double abs = nro;
if (abs < 0) abs = -abs;
Console.WriteLine("\nValor absoluto: " + abs);
double cuadrado = nro * nro;
Console.WriteLine("\nCuadrado: " + cuadrado);
double raiz = Math.Sqrt(nro);
Console.WriteLine("\nRaiz cuadrada: " + raiz);
double seno = Math.Sin(nro);
Console.WriteLine("\nSeno: " + seno);
double coseno = Math.Cos(nro);
Console.WriteLine("\nCoseno: " + coseno);
int entero = (int)nro;
Console.WriteLine("\nParte entera: " + entero);

Console.WriteLine("\nIngrese dos numeros:");
Console.WriteLine("Nro 1:");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Nro 2:");
int n2 = int.Parse(Console.ReadLine());

if (n1 >= n2)
{
    Console.WriteLine("\nEl maximo es: " + n1);
    Console.WriteLine("El minimo es: " + n2);
}
else
{
    Console.WriteLine("\nEl maximo es: " + n1);
    Console.WriteLine("El minimo es: " + n2);
}
