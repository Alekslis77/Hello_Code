/*
Дано натуральное число n (n <= 9999). 
Выяснить, верно ли, что это число 
содержит ровно три одинаковые цифры 
с учетом четырех цифр,
как, например, числа 3363, 4844, 0300 и т. п.
*/

int EnterMetod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int number = EnterMetod("Введите натуральное число <= 9999: ");

// bool ThreeDigitEvent(int numberN) // НЕ ДОДЕЛАЛ
// {
//     int number1 = 0;
//     int number2 = 0;
//     int number3 = 0;
//     int number4 = 0;
//     int temp = numberN;
//     while (temp > 0)
//     {
//         number1 = temp / 1000;
//         temp = temp % 1000;
//     }
// }
Console.WriteLine("Hello, World!");

// bool ContainsNSameDigits(int number, int n) 
// { 
//     Dictionary<int, int> counter = new Dictionary<int, int>(); 
//     while (number > 0) 
//     { 
//         if (counter.ContainsKey(number % 10)) 
//         { 
//             counter[number % 10]++; 
//         } 
//         else 
//         { 
//             counter[number % 10] = 1; 
//         }
//         number /= 10; 
//     } 
//         foreach(int value in counter.Keys) 
//     { 
//         if (counter[value] == n) 
//         { 
//             return true; 
//         } 
//     } 
//     return false; 
// }