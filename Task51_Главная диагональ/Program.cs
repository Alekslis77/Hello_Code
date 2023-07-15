/*
Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12

*/

Console.WriteLine("Hello, World!");

// int SumOfDiagonalElements(int[,] matrix)
// {
// int sumOfDiagonalElements = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i == j)
//                 sumOfDiagonalElements += matrix[i, j];
//         }
//     }
//     return sumOfDiagonalElements;
// }