/*
Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница
*/


Console.WriteLine("Введите порядковый номер дня недели: ");
int userInput = Convert.ToInt32(Console.ReadLine());
if (userInput == 1)
    Console.WriteLine("Понедельник");
else if (userInput == 2)
        Console.WriteLine("Вторник");
    else if (userInput == 3)
            Console.WriteLine("Среда");
        else if (userInput == 4)
                Console.WriteLine("Четверг");
            else if (userInput == 5)
                    Console.WriteLine("Пятница");
                else if (userInput == 6)
                        Console.WriteLine("Суббота");
                    else if (userInput == 7)
                            Console.WriteLine("Воскресенье");
                        else Console.WriteLine("Нет такого дня недели");