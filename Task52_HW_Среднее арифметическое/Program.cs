/*
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void Print2DArrayAvgCoul(int[,] arrayToPrint)
{
    double[] avgCoul = new double[arrayToPrint.GetLength(1)];
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
            avgCoul[j] = avgCoul[j] + arrayToPrint[i,j]; 
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.Write($"[AVG]\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        double avgCoulResult = avgCoul[i]/arrayToPrint.GetLength(0);
        Console.Write(string.Format("{0:0.00}", avgCoulResult) + "\t");
    }
    Console.WriteLine();
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int rowM = EnterMethod("Введите число строк m: ");
int columnN = EnterMethod("Введите число столбцов n: ");
int finalNumber = EnterMethod("Введите предельное число: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
int[,] randomArray = GetRandom2DArray(rowM, columnN, finalNumber);

Print2DArrayAvgCoul(randomArray);

