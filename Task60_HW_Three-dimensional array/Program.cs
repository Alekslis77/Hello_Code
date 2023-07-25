/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int EnterMethod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

int[,,] GetRandom3DArray(int lineNumber, int colNumber, int rowNumber)
{
    int[,,] result = new int[lineNumber, colNumber, rowNumber];
    int temp = 0;
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            for (int k = 0; k < rowNumber; k++)
            {
                temp = new Random().Next(10, 100);
                
                
                if (FindNumberInArray(result, temp) == true) 
                {
                    k--;
                }
                else 
                {
                    result[i, j, k] = temp;
                }
            }
        }
    }
    return result;
}

bool FindNumberInArray(int[,,] array, int findNumber)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == findNumber) return true;
            }
        }
    }
    return false;
}

void Print3DArray(int[,,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            for (int k = 0; k < arrayToPrint.GetLength(2); k++)
            {
                Console.Write(arrayToPrint[i, j, k]+ $"({i}, {j}, {k})" + "\t");
            }
        Console.WriteLine();
        }
    }
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int lineM = EnterMethod("Введите число строк m: ");
int columnN = EnterMethod("Введите число столбцов n: ");
int rowK = EnterMethod("Введите число рядов k: ");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
int[,,] randomArray = GetRandom3DArray(lineM, columnN, rowK);

Print3DArray(randomArray);
