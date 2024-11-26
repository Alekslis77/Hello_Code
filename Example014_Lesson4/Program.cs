// Двумерные массивы. Строки в C#
// Создание и печать двумерного массива с помощью функций
using System.IO.Pipelines;

int[,] CreateMatrix(int rowCount, int columsCount, int max)
{
    int[,] matrix = new int[rowCount,columsCount];

    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1, max+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] mtx)
{
    for (int i = 0; i < mtx.GetLength(0); i++)
    {
        for (int j = 0; j < mtx.GetLength(1); j++)
        {
            Console.Write($"{mtx[i,j]} ");
        }
    Console.WriteLine();
    }
}
int[,] matrix = CreateMatrix(4,5, 1001);
PrintMatrix(matrix);

foreach (int e in matrix)
{
    if(IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool IsInteresting(int element)
{
    bool isEven = false;
    if (SumOfDigits(element)%2 == 0) isEven = true;
    return isEven;
}

int SumOfDigits(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum = sum + num%10;
        num = num / 10;
    }
    
    return sum;
}

// Строки
string GetLettersFromString(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if(char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string? str = Console.ReadLine();
string result = GetLettersFromString(str);
Console.WriteLine(result);