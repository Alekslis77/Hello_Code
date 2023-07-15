/*
Дано трехзначное число. Определить:
а) является ли сумма его цифр двузначным числом;
б) является ли произведение его цифр трехзначным числом;
в) больше ли числа а произведение его цифр;
г) кратна ли пяти сумма его цифр;
д) кратна ли сумма его цифр числу а.
*/

// 123 x = 123 % 10 - целочисленный остаток 
// System.Console.WriteLine("Введите трёхзначное число"); 
// int number = Convert.ToInt32(Console.ReadLine());

// bool IsSumTwoDigit(int number)// number - параметр метода 
// { 
//     int sum = 0; 
//     for (int i = 0; i<3; i++) 
//         { 
//             sum = sum+number%10; 
//             number = number/10; 
//         } 
//     return sum>9;
// } 
// System.Console.WriteLine($" является ли сумма цифр двузначным числом {IsSumTwoDigit(number)}");

//number - аргумент метода
int number; 
do 
{ 
    Console.WriteLine("Enter 3 digit number"); 
    number = Convert.ToInt32(Console.ReadLine()); 
} 
while (number > 999 || number < 100); int sumOfNum(int num) 
{ 
    int sum = num / 100; 
    sum += num % 100 / 10; 
    sum += num % 10; return sum; 
} 
int productOfNum(int num)
{ 
    int product = num / 100; 
    product = num % 100 / 10;
    product = num % 10; 
    return product; 
} 
bool isSum2Digit(int num) // а
{ 
    int sum = sumOfNum(num); 
    return sum > 9; 
} 
bool isProduct3Digit(int num) // б
{
    int product = productOfNum(num);
    return product > 99; 
} 
bool isNumGreaterThanProduct(int num) // в
{ 
    int product = productOfNum(num); 
    return num > product; 
} 
bool isSumFactorOf5(int num) // г
{ 
    int sum = sumOfNum(num); 
    return sum % 5 == 0; 
} 
bool isSumFactorOfNum(int num) // д
{ 
    int sum = sumOfNum(num); 
    return num % sum == 0; 
} 
Console.WriteLine(isSum2Digit(number)); 
Console.WriteLine(isProduct3Digit(number));
Console.WriteLine(isNumGreaterThanProduct(number));
Console.WriteLine(isSumFactorOf5(number));
Console.WriteLine(isSumFactorOfNum(number));
