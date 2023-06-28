/*
Напишите программу, 
которая принимает на вход трехзначное число 
и на выходе показывает последнюю цифру числа.

456 -> 6
782 -> 2
918 -> 8
*/

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastDigit = 0;
if (number < 100 || number > 999) Console.WriteLine("Трехзначное, дундук");
else {
lastDigit = number % 10;
Console.Write($"Последняя цифра введенного числа: {lastDigit}");
}