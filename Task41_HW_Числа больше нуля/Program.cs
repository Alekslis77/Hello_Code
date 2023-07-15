/*
Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int EnterMetod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

int[] EnterArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void OutArray(int[] array)
{
    int countPositiv = 0;
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("[");
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1) Console.Write(", ");
        if (array[i] > 0) countPositiv++;
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(']');
    Console.WriteLine($"-> Чисел больше нуля: {countPositiv}");
    Console.ResetColor();
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int sizeArrey = EnterMetod("Введите число M: ");
int[] array = EnterArray(sizeArrey);

OutArray(array);
