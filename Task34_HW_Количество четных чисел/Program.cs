/*
Задайте массив заполненный случайными 
положительными трёхзначными числами. 
Напишите программу, которая покажет 
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

int EnterMethod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void OutArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("[");
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < arr.Length -1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(']');
    Console.ResetColor();
}

int countEventNumbersOfArray(int [] arrayNumbers)
{
    int result = 0;
    for(int i = 0; i < arrayNumbers.Length; i++)
    {
        if (arrayNumbers[i] % 2 == 0)
        {
            result ++;
        }
    }
    return result;
}


Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int sizeArray = EnterMethod("Введите количество элементов массива трёхзначных положительных чисел: ");
int minArr = 1; // or EnterMethod("Введите минимальное значение элемента массива: ");
int maxArr = 999; // or EnterMethod("Введите максимальное значение элемента массива: ");
Console.ForegroundColor = ConsoleColor.White;

int[] array = CreateArray(sizeArray, minArr, maxArr);
int eventCount = countEventNumbersOfArray(array);
OutArray(array);
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"Сумма четных чисел в массиве равна {eventCount}");
Console.ResetColor();