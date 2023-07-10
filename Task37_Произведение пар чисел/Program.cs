/*
Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.

[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/




// int[] ProductOfPairs(int[] numbers)
// {
//     if (numbers.Length % 2 == 0)
//     {
//         int[] products = new int[numbers.Length / 2];
//         for (int i = 0; i < products.Length; i++)
//         {
//             products[i] = numbers[i] * numbers[numbers.Length - i - 1];
//         }
//         return products;
//     }
//     else
//     {
//         int[] products = new int[numbers.Length / 2 + 1];
//         for (int i = 0; i < products.Length; i++)
//         {
//             if (i == products.Length - 1)
//             {
//                 products[i] = numbers[i];
//             }
//             else
//             {
//                 products[i] = numbers[i] * numbers[numbers.Length - i - 1];
//             }
//         }
//         return products;
//     }
    
// }

// Максим Кудинов 15:28
// int[] array = {6, 7, 3, 6};
// printArr(array);
// int[] prodArray = productOfPairs(array);
// printArr(prodArray);

// void printArr(int[] arr)
// {
//     Console.ForegroundColor = ConsoleColor.DarkGreen;
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i != arr.Length - 1)
//             Console.Write(arr[i] + ", ");
//         else
//             Console.WriteLine(arr[i] + "]");
//     }
//     Console.ForegroundColor = ConsoleColor.White;
// }

// int[] productOfPairs(int[] arr)
// {
//     int size;
//     if (arr.Length % 2 == 0)
//         size = arr.Length / 2;
//     else
//         size = arr.Length / 2 + 1;
//     int[] productArr = new int[size];

//     for(int i = 0; i < arr.Length / 2; i++)
//     {
//         productArr[i] = arr[i] * arr[arr.Length - 1 - i];
//     }
//     if(size % 2 == 1)
//         productArr[size - 1] = arr[arr.Length / 2];
//     return productArr;
// }

// int[] array = {6, 7, 3, 6};
// printArr(array);
// int[] prodArray = productOfPairs(array);
// printArr(prodArray);

// void printArr(int[] arr)
// {
//     Console.ForegroundColor = ConsoleColor.DarkGreen;
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i != arr.Length - 1)
//             Console.Write(arr[i] + ", ");
//         else
//             Console.WriteLine(arr[i] + "]");
//     }
//     Console.ForegroundColor = ConsoleColor.White;
// }

// int[] productOfPairs(int[] arr)
// {
//     int size = arr.Length / 2 + arr.Length % 2;
//     int[] productArr = new int[size];

//     for(int i = 0; i < arr.Length / 2; i++)
//     {
//         productArr[i] = arr[i] * arr[arr.Length - 1 - i];
//     }
//     if(size % 2 == 1)
//         productArr[size - 1] = arr[arr.Length / 2];
//     return productArr;
// }
