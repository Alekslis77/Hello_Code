/*
Составить программу:
 а) вычисления значения функции y=7x2+3x+6 при любом значении x;
 б) вычисления значения функции x=12a2+7a+12 при любом значении а.
*/


Console.Write("Задайте значение a: ");
double a = Convert.ToDouble(Console.ReadLine());
double x = 12*Math.Pow(a, 2)+7*a+12; 
Console.Write($"При a = {a}:\n x = {x}\n y = {7*Math.Pow(x, 2)+3*x+6}");
