/*
Проверить, принадлежит ли число, 
введенное с клавиатуры, интервалу (–5, 3).
*/

int EnterMetod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

bool IsInRange(int number, int start, int finish)
{
    if ((number >= start) && (number <= finish))
    {
        return true;
    }
    else
    {
        return false;
    }
    /* return (number >= start) && (number <= finish); */
}

int number = EnterMetod("Введите число: ");
Console.WriteLine($"Принадлежит ли число интевалу: -5, 3 -> {IsInRange(number, -5, 3)}");