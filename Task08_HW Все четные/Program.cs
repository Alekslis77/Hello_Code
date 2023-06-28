/*
Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberN >= 2)
{
int count = 2;
Console.Write($"Четные числа от 1 до {numberN} -> ");
while (count <= numberN)
{
    if (count % 2 == 0) {
        Console.Write($"{count}");
        if (count < numberN - 1) Console.Write(", ");
        }
count++;
}
}
else Console.Write("Четных натуральных чисел нет");
