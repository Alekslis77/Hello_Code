/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу квадратов чисел от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

string TabQvad(int N)
{
    string result = "1";
    int temp = 0;
    for (int i = 2; i <= Math.Abs(N); i++)
    {    
        temp = i*i;
        result = result + $", {temp}";
    }
    return result;
}

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} -> {TabQvad(number)}");

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// while (count <= n)
// {
// Console.Write($"{Math.Pow(count, 2)}");
// if (count != n)
// {
// Console.Write(", ");

// }
// else
// Console.Write(".");
// count++;
// }