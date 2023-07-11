/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.

Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

*/

Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int prevSum2 = 0;
int prevSum1 = 1;
int sum = 0;
Console.Write(prevSum2 + " ");
Console.Write(prevSum1 + " ");
for(int i = 0; i < number - 2; i++)
{
    sum = prevSum1 + prevSum2;
    Console.Write(sum + " ");
    prevSum2 = prevSum1;
    prevSum1 = sum;
}

// //////////////////////////////////

// Console.WriteLine("Бонджорно, рагацци! Сколько чисел Фибаначчи вам вывестиамо? ");
// int N = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// int number = 0;
// int result = 0;
// while (count <= N) 
// {
//     result = number + count;
//     Console.Write ($" {result}, ");
//     number = count;
//     count = count + 1;
// }

// Михаил  кому  Все 14:53
// Console.Write("Введите число N - ");
// int n = Convert.ToInt32(Console.ReadLine());
// int firstNum = 0;
// int secondNum = 1;
// for (int i = 0; i < n; i++)
// {
//     Console.Write(firstNum + " ");
//     int temp = firstNum;
//     firstNum = secondNum;
//     secondNum = temp + secondNum;
// }

// nikolajglazkov  кому  Все 14:54
// Что то не как
// int Fibonacci(int n)
// {
//     int a = 0;
//     int b = 1;
//     for (int i = 0; i < n; i++)
//     {
//         int temp = a;
//         a = b;
//         b = temp + b;
//     }
//     return a;
// }
// Console.Write("Введите число :");
// int num = Convert.ToInt32(Console.Read());

// for (int i = 0; i < num; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }
// Почему он идет дальше 7???

// Вы  кому  Все 14:55
// Console.WriteLine("Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int prevSum2 = 0;
// int prevSum1 = 1;
// int sum = 0;
// Console.Write(prevSum2 + " ");
// Console.Write(prevSum1 + " ");
// for(int i = 0; i < number - 2; i++)
// {
//     sum = prevSum1 + prevSum2;
//     Console.Write(sum + " ");
//     prevSum2 = prevSum1;
//     prevSum1 = sum;
// }

// Михаил  кому  Все 14:57
// Console.Write("Введите число N - ");
// int N = Convert.ToInt32(Console.ReadLine());
// int firstNum = 0;
// int secondNum = 1;

// void Fibonacci(int number)
// {
//     Console.Write("[");
//     for (int i = 0; i < N; i++)
//     {
//         Console.Write(firstNum);
//         if (i != N - 1)
//         {
//             Console.Write(", ");
//         }
//         int temp = firstNum;
//         firstNum = secondNum;
//         secondNum = temp + secondNum;
//     }
//     Console.Write("]");
// }

// Fibonacci(N);

// nikolajglazkov  кому  Все 14:57
// Да просто вывести их и все

// Malik 15:00
// Console.WriteLine("input number");
// int number = Convert.ToInt32(Console.ReadLine());
// int number1 = 0;
// int number2 = 1;
// int fibi = 0;
// Console.Write(number1 + " ");
// Console.Write(number2 + " ");

// for (int i = 2; i < number; i++ )
// {
//     fibi = number1 + number2;
//     Console.Write(fibi + " ");
//     number1 = number2;
//     number2 = fibi;

// }

