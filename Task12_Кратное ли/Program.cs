/*
Напишите программу, которая будет принимать на вход два числа 
и выводить, является ли второе число кратным первому. 
Если второе число некратно первому, 
то программа выводит остаток от деления.

34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/

Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int ost = numberTwo % numberOne;

if (ost == 0) Console.WriteLine($"{numberTwo}, {numberOne} -> кратно");
else Console.WriteLine($"{numberTwo}, {numberOne} -> некратно, остаток {ost}");
