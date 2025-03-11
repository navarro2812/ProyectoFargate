﻿using System;

Console.WriteLine("Calculadora Básica prueba 2");

// Solicitar el primer número
Console.Write("Ingrese el primer número rapido: ");
double numero1;
while (!double.TryParse(Console.ReadLine(), out numero1))
{
    Console.Write("Ingrese un número válido: ");
}

// Solicitar el segundo número
Console.Write("Ingrese el segundo número: ");
double numero2;
while (!double.TryParse(Console.ReadLine(), out numero2))
{
    Console.Write("Ingrese un número válido: ");
}

// Realizar operaciones
double suma = numero1 + numero2;
double resta = numero1 - numero2;
double multiplicacion = numero1 * numero2;
string division = (numero2 != 0) ? (numero1 / numero2).ToString("F2") : "Error: No se puede dividir entre cero";

// Mostrar resultados
Console.WriteLine("\nResultados:");
Console.WriteLine("Suma: " + suma);
Console.WriteLine("Resta: " + resta);
Console.WriteLine("Multiplicación: " + multiplicacion);
Console.WriteLine("División: " + division);

Console.WriteLine("\nPresiona cualquier tecla para finalizar...");
Console.ReadKey();
