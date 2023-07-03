/*
Напишите программу, которая принимает на вход два числа 
и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int squareOne = numberOne * numberOne;
int squareTwo = numberTwo * numberTwo;

if (numberOne == squareTwo || numberTwo == squareOne)
{
    Console.WriteLine($"{numberOne}, {numberTwo} -> да");
}
else Console.WriteLine($"{numberOne}, {numberTwo} -> нет");

