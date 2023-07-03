/*
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

int ReversNumber(int digit, int numb)
{
    int reverse = 0;
    int temp = numb;
    for (int i = digit-1; i >= 0 ; i--)
    {
        reverse = reverse + ((temp % 10) * Convert.ToInt32(Math.Pow(10, i)));
       temp =  temp / 10;
    }
    return reverse;
}

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999) 
{
    Console.WriteLine($"Число {number} не является пятизначным");
}
else 
{
    if (number == ReversNumber(5, number))
    {
        Console.WriteLine($"Является ли число {number} палиндромом? -> да");
    }
    else
    {
        Console.WriteLine($"Является ли число {number} палиндромом? -> нет");
    }
}

