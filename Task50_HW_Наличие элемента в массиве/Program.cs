/*
Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, 
и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i=1 j=7 -> такого числа в массиве нет
*/

int EnterMethod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

int[,] GetRandom2DArray()
{
    int rowNumber = new Random().Next(1, 9 + 1);
    int colNumber = new Random().Next(1, 9 + 1);
    int deviation = new Random().Next(1, 9 + 1);
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return result;
}

void Print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{i}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindElementArray(int[,] arrayFind, int iIN, int jIN)
{
    int flagIndex = 0;
    for (int i = 0; i < arrayFind.GetLength(0); i++)
    {
        for (int j = 0; j < arrayFind.GetLength(1); j++)
        {
            if ((iIN == i) && (jIN == j)) {
                Console.WriteLine($"Элемент по указанным индексам: -> {arrayFind[i, j]}");
                flagIndex = 1;
            }
        }
    }
    if (flagIndex == 0) Console.WriteLine($"Элемента с такими индексами в массиве нет"); 
}

Console.Clear();
int[,] randomArray = GetRandom2DArray();
Print2DArray(randomArray);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Yellow;
int rowIndex = EnterMethod("Введите индекс строки i: ");
int columnIndex = EnterMethod("Введите индекс строки j: ");
Console.ForegroundColor = ConsoleColor.White;
FindElementArray(randomArray, rowIndex, columnIndex);


