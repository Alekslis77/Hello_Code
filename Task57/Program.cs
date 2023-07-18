/*
Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных
{ 1, 9, 9, 0, 2, 8, 0, 9 }
0 встречается 2 раза
1 встречается 1 раз
2 встречается 1 раз
8 встречается 1 раз
9 встречается 3 раза

1, 2, 3
4, 6, 1
2, 1, 6
1 встречается 3 раза
2 встречается 2 раза
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/
// void CountElementsInMatrix(int[,] matrix, Dictionary<int, int> counter)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (counter.ContainsKey(matrix[i, j]))
//             {
//                 counter[matrix[i, j]]++;
//             }
//             else
//             {
//                 counter.Add(matrix[i, j], 1);
//             }
//         }
//     }
// }

// Dictionary<int, int> counter = new Dictionary<int, int>();
// int[,] matrix = CreateAndFillMatrix(4, 5, 1, 9);
// PrintMatrix(matrix);
// CountElementsInMatrix(matrix, counter);
// Console.WriteLine();
// foreach (int key in counter.Keys)
// {
//     Console.WriteLine($"There are {counter[key]} {key}'s");
// }