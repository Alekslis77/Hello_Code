/*
Известны год и номер месяца рождения человека, 
а также год и номер месяца сегодняшнего дня 
(январь — 1 и т. д.).
Определить возраст человека (число полных лет). 
В случае совпадения указанных номеров месяцев считать, 
что прошел полный год.
*/

int EnterMetod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
int yearBirth = EnterMetod("Введите год рождения YYYY: ");
int monthBirth = EnterMetod("Введите месяц рождения MM: ");
int yearNow = 2023;
int monthNow = 7;
int diffYear = yearNow - yearBirth;
Console.ForegroundColor = ConsoleColor.Green;
if (monthBirth > monthNow)
{
    
    Console.Write($"Возраст человека составляет {diffYear - 1} полных лет");
}
else
{
    Console.Write($"Возраст человека составляет {diffYear} полных лет");
}
Console.ResetColor();
