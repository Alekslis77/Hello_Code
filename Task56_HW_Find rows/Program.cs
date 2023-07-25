﻿/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int EnterMethod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

int[,] GetRandom2DArray(int rowNumber, int colNumber, int deviation)
{
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

int FindRowSumMin(int[,] array)
{
    int sumRowNumber = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = temp + array[i,j];
        }
        if (temp < sum) 
            {
                sumRowNumber = i;
                sum = temp;
            }
    }
    return sumRowNumber;
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int rowM = EnterMethod("Введите число строк m: ");
int columnN = EnterMethod("Введите число столбцов n: ");
int finalNumber = EnterMethod("Введите предельное число: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
int[,] randomArray = GetRandom2DArray(rowM, columnN, finalNumber);

Print2DArray(randomArray);
Console.WriteLine();

int minSum = FindRowSumMin(randomArray);
Console.WriteLine($"Cтрока с индексом {minSum} - с наименьшей суммой элементов");