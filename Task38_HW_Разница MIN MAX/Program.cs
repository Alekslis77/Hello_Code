/*
Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.

[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

int EnterMethod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

double[] CreateArrayOfRealNumbers(int length, int max)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble()*max;
    }
    return array;
}

void OutDiffMinMaxArray(double[] arr)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("[");
    Console.ForegroundColor = ConsoleColor.Green;
    double minElement = arr[0];
    double maxElement = arr[0];
    double diff = 0;
    for (int i = 0; i < arr.Length -1; i++)
    {
        Console.Write(string.Format("{0:0.00}\t", arr[i]));
        if (arr[i] > maxElement) maxElement = arr[i];
        else if (arr[i] < minElement) minElement = arr[i];
    }
    diff = maxElement - minElement;
    Console.Write(string.Format("{0:0.00}",arr[arr.Length - 1]));
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(']');
    Console.ResetColor();
    Console.WriteLine(" => ");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write($"=> Разница между максимальным {string.Format("{0:0.00}", maxElement)}" +
                                    $" и минимальным {string.Format("{0:0.00}", minElement)}");
    Console.Write($" элементами массива равна {string.Format("{0:0.00}", diff)}");
    Console.ResetColor();
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int sizeArray = EnterMethod("Введите количество элементов массива вещественных чисел: ");
int maxArr = EnterMethod("Введите максимальное значение элемента массива: ");
Console.ForegroundColor = ConsoleColor.White;

double[] array = CreateArrayOfRealNumbers(sizeArray, maxArr);
OutDiffMinMaxArray(array);

