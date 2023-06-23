/*
Вывести на экран два числа от пользователя одно под другим.
*/

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Вы ввели числа:\n{number1}\n{number2}");
