/*
Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int EnterMethod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

double[,] GetRandom2DArrayReal(int rowNumber, int colNumber, int deviation)
{
    double[,] result = new double[rowNumber, colNumber];
    Random rand = new Random(); 
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i,j] = rand.Next(-deviation, deviation)*rand.NextDouble();
        }
    }
    return result;
}

void Print2DArray(double[,] arrayToPrint)
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
            Console.Write(string.Format("{0:0.00}", arrayToPrint[i,j]) + "\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int rowM = EnterMethod("Введите число строк m: ");
int columnN = EnterMethod("Введите число столбцов n: ");
int finalNumber = EnterMethod("Введите предельное число: ");

Console.ForegroundColor = ConsoleColor.White;

double[,] array = GetRandom2DArrayReal(rowM, columnN, finalNumber);

Print2DArray(array);