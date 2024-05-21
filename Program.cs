// See https://aka.ms/new-console-template for more information

// int n, invertido = 0, digito;

// Console.WriteLine("Ingrese un numero");
// string numero = Console.ReadLine();


// if (int.TryParse(numero, out n))
// {
//     n = Convert.ToInt32(numero);

//     while (n > 0)
//     {
//         // Obtener el último dígito del número
//         digito = n % 10;

//         // Agregar el dígito al número invertido
//         invertido = invertido * 10 + digito;

//         // Eliminar el último dígito del número original
//         n /= 10;
//     }
// }

// Console.WriteLine("Numero original:" + numero);
// Console.WriteLine("Numero invertido:" + invertido);

// Ejercicio 2

int seguir = 0;

do
{
    Console.WriteLine("Elija la opcion:");
    Console.WriteLine("1.Sumar");
    Console.WriteLine("2.Restar");
    Console.WriteLine("3.Multiplicar");
    Console.WriteLine("4.Dividir");
    int opcion = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese dos numeros:");
    Console.WriteLine("Nro 1:");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Nro 2:");
    int n2 = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            int suma = n1 + n2;
            Console.WriteLine("Suma = " + suma);
            break;
        case 2:
            int resta = n1 - n2;
            Console.WriteLine("Resta = " + resta);
            break;
        case 3:
            int multi = n1 * n2;
            Console.WriteLine("Multiplicacion = " + multi);
            break;
        case 4:
            float division = (float)n1 / n2;
            Console.WriteLine("Division = " + division);
            break;

        default:
            Console.WriteLine("Opcion incorrecta");
            break;
    }
    Console.WriteLine("Realizar otra operacion? :  1. Si  2. No");
    seguir = int.Parse(Console.ReadLine());


} while (seguir == 1);