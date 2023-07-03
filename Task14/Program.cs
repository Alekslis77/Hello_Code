/*
Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да
*/

Console.WriteLine("Введите число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

if (numberOne % 7 == 0 && numberOne % 23 == 0) 
{
    Console.WriteLine($"{numberOne} -> да");
}
else 
{
    Console.WriteLine($"{numberOne} -> нет");
}

// Console.WriteLine("Солнышко, а можешь порадовать меня и ввести число?");
// int Num = Convert.ToInt32(Console.ReadLine());

// if ((Num % 7 == 0) && (Num % 23 == 0)) 
// Console.WriteLine("Да, делится и на 7 и на 23, солнышко");
// else Console.WriteLine("Нет, не делится, солнышко");