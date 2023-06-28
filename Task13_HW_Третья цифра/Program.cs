/*
Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int CountNumber(int a) { // Считает количество цифр в числе
    int count = 0;
    int temp = a;
    while(temp > 0)
        {
            temp = temp / 10;
            count++;
        }
    return count; 
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 ) {
    Console.WriteLine("Третьей цифры нет.");
}
else {
    Console.WriteLine("Количество цифр в числе: " + 
                        $"{CountNumber(number)}");
    int size = CountNumber(number);
    int[] numbArray = new int[size];
    int i = number;
    while ( size > 0 ) {
        numbArray[size-1] =  i % 10;
        i = i / 10;
        size = size - 1;
    }
    Console.WriteLine("Третья цифра в числе " + 
                    $"{number} -> {numbArray[2]}");
}