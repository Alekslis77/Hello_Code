/*
Задайте двумерный массив. 
Напишите программу, 
которая упорядочит по убыванию 
элементы каждой строки 
двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

void SortRowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = array[i,0];
        for (int j = 1; j < array.GetLength(1); j++)
        {
                for (int k = array.GetLength(1) - (array.GetLength(1) - 1); k < array.GetLength(1); k++)
                {
                    if (array[i,k] > array[i,k-1]) 
                    {
                        temp = array[i,k-1];
                        array[i,k-1] = array[i,k];
                        array[i,k] = temp;
                    }
                    
                }
                
        }
    }
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
SortRowArray(randomArray);
Console.WriteLine();
Print2DArray(randomArray);
