void pyramidSort(int[] arr)
{
    int n = arr.Length;
    for (int i = n / 2 - 1; i >= 0; i--)
        heapify(arr, n, i);

    for (int i=n-1; i>=0; i--)
    {
        int temp = arr[0];
        arr[0] = arr[i];
        arr[i] = temp;

        heapify(arr, i, 0);
    }
}

void heapify(int[] arr, int n, int i)
{
    int largest = i;
    int l = 2*i + 1;
    int r = 2*i + 2;

    if (l < n && arr[l] > arr[largest])
        largest = l;

    if (r < n && arr[r] > arr[largest])
        largest = r;

    if (largest != i)
    {
        int swap = arr[i];
        arr[i] = arr[largest];
        arr[largest] = swap;

        heapify(arr, n, largest);
    }
}

int EnterMethod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void OutArray(int[] arr)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("[");
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < arr.Length -1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(']');
    Console.ResetColor();
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int sizeArray = EnterMethod("Введите количество элементов массива: ");
int minArr = EnterMethod("Введите минимальное значение элемента массива: ");
int maxArr = EnterMethod("Введите максимальное значение элемента массива: ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
int[] array = CreateArray(sizeArray, minArr, maxArr);
Console.WriteLine("Массив до сортировки:"); 
OutArray(array);
pyramidSort(array);
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Сортированный массив:");
OutArray(array);
Console.ResetColor();

