/*
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int ExpAtoB(int num, int exp )
{
    int result = 1;
    if (exp < 0) 
    {
        result = -1;
    }
    else for (int i = 1; i <= exp; i++)
            {
                result = result*num;
            }
    return result;
}

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
start:
Console.WriteLine("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0) 
{
    Console.WriteLine("Показатель степени B должен быть натуральным числом. ");
    goto start;
}
else Console.WriteLine($"Число A({numberA}) в степени B({numberB})" +
                    $" - > {ExpAtoB(numberA, numberB)}");

