/*
Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
*/
int[] GenerateArray(int length, int start, int end)
{
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

void PrintArray(int[] arr, string name = "")
{
    Console.WriteLine(name);
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if( i != arr.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int[] reverseArray (int[] arr)
{
    int[] result = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[arr.Length -1 - i];
    }
    return result;
}

int[] numbers = GenerateArray(10, -100, 100);
int[] revArray = reverseArray(numbers);
PrintArray(numbers, "Начальный");
PrintArray(revArray, "Перевёрнутый");


