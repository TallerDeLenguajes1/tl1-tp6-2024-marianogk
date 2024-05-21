// See https://aka.ms/new-console-template for more information

int n, invertido = 0, digito;

Console.WriteLine("Ingrese un numero");
string numero = Console.ReadLine();


if (int.TryParse(numero, out n))
{
    n = Convert.ToInt32(numero);

    while (n > 0)
    {
        // Obtener el último dígito del número
        digito = n % 10;

        // Agregar el dígito al número invertido
        invertido = invertido * 10 + digito;

        // Eliminar el último dígito del número original
        n /= 10;
    }
}

Console.WriteLine("Numero original:" + numero);
Console.WriteLine("Numero invertido:" + invertido);

