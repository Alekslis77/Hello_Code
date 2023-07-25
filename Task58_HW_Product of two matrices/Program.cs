/*
Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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
            Console.Write(arrayToPrint[i,j] + "\t");
        }
        Console.WriteLine();
    }
}


int[,] ProductArray(int[,] arrayA, int[,] arrayB)
{
    int[,] result = new int[arrayA.GetLength(0),arrayA.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
        {
            for (int j = 0; j < arrayA.GetLength(1); j++)
            {
                    int temp = 0;
                for (int k = 0; k < arrayA.GetLength(1); k++)
                {
                    temp = temp + arrayA[i,k] * arrayB[k,j];
                }
                    result[i, j] = temp;
                    temp = 0;
            }
        }
    return result;
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int rowMa = EnterMethod("Введите число строк m матрицы A: ");
int columnNa = EnterMethod("Введите число столбцов n матрицы A: ");
int rowMb = EnterMethod("Введите число строк m матрицы B: ");
int columnNb = EnterMethod("Введите число столбцов n матрицы B: ");
int finalNumber = EnterMethod("Введите предельное число: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
if (rowMa != columnNb) 
{
    Console.WriteLine("Произведения матрицы А и В не существует ");
}
else
{
    int[,] randomArrayA = GetRandom2DArray(rowMa, columnNa, finalNumber);
    int[,] randomArrayB = GetRandom2DArray(rowMb, columnNb, finalNumber);
    int[,] resultProductArray = ProductArray(randomArrayA, randomArrayB);
    Console.WriteLine("Матрица A:");
    Print2DArray(randomArrayA);
    Console.WriteLine("Матрица B:");
    Print2DArray(randomArrayB);
    Console.WriteLine("Матрица произведения A на B:");
    Print2DArray(resultProductArray);
}
