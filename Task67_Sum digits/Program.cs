/*
Напишите программу, которая будет принимать на вход число 
и возвращать сумму его цифр.

453 -> 12
45 -> 9
*/
// int SumOfDigits(int number)
// {
//     if (number < 10)
//     {
//         return number;
//     }
//     else
//     {
//         return number % 10 + SumOfDigits(number / 10);
//     }
// }

// int recSum(int num)
// {
//     if(num != 0)
//     {
//         return num % 10 + recSum(num / 10);
//     }
//     return 0;
// }

// Console.WriteLine(recSum(45));