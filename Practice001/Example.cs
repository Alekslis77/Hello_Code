/*
    Это простая программа на C#.
*/
//using System;
//using System.Text;
//using System.Text.Unicode;

class Example {
    // Любая программа начинается с метода Main() 
    static void Main() {
        //Console.InputEncoding = Encoding.GetEncoding(1200);
        // Объявление и инициализация переменных X,Y
        int x = 100;
        int y = x/2;
        
        decimal price;
        decimal discount;
        decimal discounted_price;

        //Рассчитать цену со скидкой.
        price = 19.95m;
        discount = 0.15m; // Норма скидки составляет 15%
        
        discounted_price = price - (price*discount);

        Console.WriteLine("Цена со скидкой: {0:C}", discounted_price);
        //string? username = Console.ReadLine();
        // string username = "фдуч";
        // Здесь имя Console.WriteLine полностью определено
        //Console.Write("Половина x = {0,10} содержит x/2 = {1,15}: ", x, y);
        //if (username is not null) {
        //        Console.WriteLine(username);
        //}
        //Console.WriteLine(y);
    }
}