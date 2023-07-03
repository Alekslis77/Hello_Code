/*
Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();
int[] NewArray()
{
    int[] array = new int[8]{0, 0, 0, 0, 0, 0, 0, 0};
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
       array[index] = new Random().Next(1, 100);
       index++; 
    }
    return array;
}

void PrintRandArray(int[] array)
{
    Console.Write("[");
    int size = new Random().Next(1, array.Length);
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i]); 
        if (i < size - 1) 
        {
            Console.Write(", "); 
        }
    }
    Console.Write("]");
} 

PrintRandArray(NewArray());

