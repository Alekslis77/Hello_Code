/*
Задайте значение N. Напишите программу, 
которая выведет все натуральные числа 
в промежутке от N до 1.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int EnterMethod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

string RecursionN(int number)
{
    if (number == 1) return $"{number}";
    else return $"{number}, {RecursionN(number - 1)}";
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int numberN = EnterMethod("Введите число строк N: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

Console.Write($"N = {numberN} -> \"{RecursionN(numberN)}\"");
