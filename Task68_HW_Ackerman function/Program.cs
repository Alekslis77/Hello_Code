/*
Напишите программу вычисления 
функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int EnterMethod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

int FunctionAckermanMN(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numN == 0) return FunctionAckermanMN(numM - 1, 1);
    return FunctionAckermanMN(numM - 1, FunctionAckermanMN(numM, numN - 1));
}

Console.Clear();
Start:
Console.ForegroundColor = ConsoleColor.Yellow;
int numberM = EnterMethod("Введите натуральное число m: ");
int numberN = EnterMethod("Введите натуральное число n: ");
if (numberM < 0 || numberN < 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Введите числа такие, что m и n > = 0");
    goto Start;
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();

Console.Write($"m = {numberM}; n = {numberN};" + 
        $" -> A(m,n) = {FunctionAckermanMN(numberM, numberN)}");
