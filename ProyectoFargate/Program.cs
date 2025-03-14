using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora Básica prueba 8");

        double numero1 = LeerNumero("Ingrese el primer número: ");
        double numero2 = LeerNumero("Ingrese el segundo número: ");

        MostrarResultados(numero1, numero2);

        Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
        Console.ReadKey();
    }

    static double LeerNumero(string mensaje)
    {
        Console.Write(mensaje);
        double numero;
        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Ingrese un número válido rapido v2: ");
        }
        return numero;
    }

    static void MostrarResultados(double numero1, double numero2)
    {
        Console.WriteLine("\nResultados:");
        Console.WriteLine("Suma: " + (numero1 + numero2));
        Console.WriteLine("Resta: " + (numero1 - numero2));
        Console.WriteLine("Multiplicación: " + (numero1 * numero2));
        Console.WriteLine("División: " + (numero2 != 0 ? (numero1 / numero2).ToString("F2") : "Error: No se puede dividir entre cero"));
    }
}
