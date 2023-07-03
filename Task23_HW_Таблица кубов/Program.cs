/*
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

string TabQvad(int N)
{
    string result = "1";
    int temp = 0;
    for (int i = 2; i <= Math.Abs(N); i++)
    {    
        temp = i*i*i;
        result = result + $", {temp}";
    }
    return result;
}

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} -> {TabQvad(number)}");

