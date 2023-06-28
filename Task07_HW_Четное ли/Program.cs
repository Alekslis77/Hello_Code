/*
Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число для проверки четности: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write($"Число {number} четное ? -> ");
if (number % 2 == 0) Console.Write("Да");
else Console.Write("Нет");
