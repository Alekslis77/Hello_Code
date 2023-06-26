/*
Напишите программу, которая принимает на вход два числа 
и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2; b = 10 -> нет
a = 9; b = -3 -> да
a = -3; b = 9 -> нет 
*/

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2*number2) Console.WriteLine("Да");
else Console.WriteLine("Нет");

// int number1 = Convert.ToInt32(Console.ReadLine());
// int number2 = Convert.ToInt32(Console.ReadLine());
// bool result = false;
//
// if (number1 == number2*number2) result = true;
//
//Console.WriteLine(result);
