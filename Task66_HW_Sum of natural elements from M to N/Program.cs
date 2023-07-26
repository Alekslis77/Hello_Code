/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов 
в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int EnterMethod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

int RecursionSumMN(int numM, int numN)
{
    if (numN < numM) return 0;
    else return numN + RecursionSumMN(numM, numN - 1);
}

Console.Clear();
Start:
Console.ForegroundColor = ConsoleColor.Yellow;
int numberM = EnterMethod("Введите натуральное число M: ");
int numberN = EnterMethod("Введите натуральное число N: ");
if (numberM > numberN)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Введите числа такие, что M < N");
    goto Start;
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

Console.Write($"M = {numberM}; N = {numberN}; -> {RecursionSumMN(numberM, numberN)}");