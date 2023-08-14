using System;

namespace SumaNumerosPares
{
class Program
{
static void Main(string[] args)
{
Console.Write("Ingrese el valor mínimo del rango: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Ingrese el valor máximo del rango: ");
int max = int.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de números pares a sumar: ");
int n = int.Parse(Console.ReadLine());
int suma = 0;
int count = 0;

for (int i = min; i <= max && count < n; i++)
{
 if (i % 2 == 0)
 {
  suma += i;
   count++;
 }
 }

 Console.WriteLine($"La suma de los primeros {n} números pares en el rango [{min}, {max}] es: {suma}");
  }
 }
}
