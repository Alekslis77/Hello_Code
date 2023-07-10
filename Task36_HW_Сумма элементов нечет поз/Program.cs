/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int sumOddIndexElementOfArray(int [] arrayNumbers)
{
    int result = 0;
    for(int i = 0; i < arrayNumbers.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += arrayNumbers[i];
        }

    }
    return result;
}


Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int sizeArray = EnterMethod("Введите количество элементов массива трёхзначных положительных чисел: ");
int minArr = EnterMethod("Введите минимальное значение элемента массива: ");
int maxArr = EnterMethod("Введите максимальное значение элемента массива: ");
Console.ForegroundColor = ConsoleColor.White;

int[] array = CreateArray(sizeArray, minArr, maxArr);
int oddCount = sumOddIndexElementOfArray(array); 
OutArray(array);
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Сумма чисел массива, стоящих на нечетных позициях равна {oddCount}");
Console.ResetColor();