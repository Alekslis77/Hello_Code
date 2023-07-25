/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int EnterMethod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

int[,] Get2DSpiral(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    int num = 0;
    int x = 0;
    if (rowNumber < colNumber) x = rowNumber / 2;
    if (colNumber < rowNumber) x = colNumber / 2;
    if (rowNumber == colNumber) x = rowNumber / 2;
    if (x > 1 && x < 2) x = 2;
    if (x < 1) x = 1;
    
    for (int n = 0; n < x; n++)
    {
        for (int j = 0 + n; j < colNumber - n; j++)
        {
            num ++; 
            result[0 + n,j] = num;
        }

        for (int i =  1 + n; i < rowNumber - n; i++)
        {
            num ++; 
            result[i,colNumber - 1 - n] = num;
        }

        for (int j = (colNumber - 2) - n; j >= 0 + n; j--)
        {
            num ++; 
            result[rowNumber - 1 - n,j] = num;
        }
        for (int i = (rowNumber - 2) - n; i >= 1 + n; i--)
        {
            num ++; 
            result[i,0 + n] = num;
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

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int rowM = EnterMethod("Введите число строк m: ");
int columnN = EnterMethod("Введите число столбцов n: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
int[,] randomArray = Get2DSpiral(rowM, columnN);

Print2DArray(randomArray);
