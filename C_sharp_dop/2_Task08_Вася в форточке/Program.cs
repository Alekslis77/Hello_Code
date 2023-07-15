/*
Вася пытается высунуть голову в форточку размерами a и b см. 
Приняв условно, что его голова — круглая диаметром d см,
определить, сможет ли Вася сделать это. 
Для прохождения головы в форточку необходим зазор в 1 см с каждой стороны.
*/

int EnterMetod(string textOut)
{
    Console.Write(textOut);
    int numberIn = Convert.ToInt32(Console.ReadLine());
    return numberIn;
}

bool CanVasyaStickHisHeadOut(int aSide, int bSide, int diameter) 
{ 
    if (aSide - diameter >= 2 && bSide - diameter >= 2) return true;
    else return false; 
}

int sideA = EnterMetod("Введите длину стороны a: ");
int sideB = EnterMetod("Введите длину стороны b: ");
int diam = EnterMetod("Введите диаметр головы Васи: ");
Console.WriteLine($"Пролезет ли Вася в форточку? -> {CanVasyaStickHisHeadOut(sideA, sideB, diam)}");