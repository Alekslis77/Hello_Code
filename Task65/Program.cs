﻿/*
Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

void RecursionNumberMN(int start, int finish)
{
    if (start <= finish) 
    {
        Console.Write(start + " ");
        RecursionNumberMN(start + 1, finish);
    }
}

RecursionNumberMN(4, 8);