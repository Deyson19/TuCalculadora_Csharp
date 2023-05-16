// See https://aka.ms/new-console-template for more information
using TuCalculadora;


    Console.WriteLine("Hello, World!");

    Suma suma = new();
    Resta resta = new();
    Multiplicacion multiplicacion = new();
    Division division = new();

    // Ejemplo de suma
    suma.ValorActual = 5;
    suma.Sumar(3);
    Console.WriteLine("5 + 3 = " + suma.ValorActual);

    // Ejemplo de resta
    resta.ValorActual = 10;
    resta.Restar(2);
    Console.WriteLine("10 - 2 = " + resta.ValorActual);

    // Ejemplo de multiplicacion
    multiplicacion.ValorActual = 4;
    multiplicacion.Multiplicar(5);
    Console.WriteLine("4 * 5 = " + multiplicacion.ValorActual);

    // Ejemplo de division
    division.ValorActual = 18;
    division.Dividir(6);
    Console.WriteLine("18 / 6 = " + division.ValorActual);

Console.ReadKey();
