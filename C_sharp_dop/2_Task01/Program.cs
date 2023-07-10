/*
Написать метод заполнения массива рандомными цифрами от 10 до 99 
(этот метод нам дальше будет нужен везде, так что делаем красивый. 
Чтобы цифры через ",", по желанию можно выделять цветом 
(не забываем только что цвет надо включить а потом выключить), 
чтобы в начале и в конце массива были "[]").
*/

int EnterMetod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
    return array;
}

void OutArray(int[] array)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("[");
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < array.Length -1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(']');
    Console.ResetColor();
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int sizeArrey = EnterMetod("Введите размерность массива Array: ");
int minArr = 10; // or EnterMetod("Введите минимальное значение элемента массива: ");
int maxArr = 99; // or EnterMetod("Введите максимальное значение элемента массива: ");

int[] array = CreateArray(sizeArrey, minArr, maxArr);

OutArray(array);
