/*
Напишите программу, которая на вход принимает два числа 
и выдаёт первые N чисел, для которых каждое следующее 
равно сумме двух предыдущих.

3 и 4, N = 5 -> 3 4 7 11 18
6 и 10, N = 4 -> 6 10 16 26
*/

int EnterMethod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

int FibonacciN(int numOne, int numTwo, int n)
{
    if (n == 1) return numOne;
    if (n == 2) return numTwo;
    else return FibonacciN(numOne, numTwo, n-1) + FibonacciN(numOne, numTwo, n-2);
}

Console.Clear();
Start:
Console.ForegroundColor = ConsoleColor.Yellow;
int numberOne = EnterMethod("Введите первое число: ");
int numberTwo = EnterMethod("Введите второе число: ");
int numberN = EnterMethod("Введите натуральное число N: ");
if (numberOne > numberTwo)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Введите числа такие, первое меньше второго");
    goto Start;
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

Console.Write($"{numberOne} и {numberTwo}, N = {numberN} -> ");
for (int i = 1; i <= numberN; i++)
{
    Console.Write($"{FibonacciN(numberOne, numberTwo, i)} ");
}
Console.WriteLine();

