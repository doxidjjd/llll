using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Розширений конвертер метрів");
        Console.WriteLine("Введіть кількість метрів:");
        
        double meters;
        while (!double.TryParse(Console.ReadLine(), out meters) || meters <= 0)
        {
            Console.WriteLine("Будь ласка, введіть коректне значення більше 0:");
        }

        Console.WriteLine("\nОберіть одиниці для конвертації:");
        Console.WriteLine("1 - Милі");
        Console.WriteLine("2 - Дюйми");
        Console.WriteLine("3 - Ярди");
        Console.WriteLine("4 - Кілометри");
        Console.WriteLine("5 - Сантиметри");
        Console.WriteLine("6 - Міліметри");
        Console.WriteLine("7 - Мікрометри");
        Console.WriteLine("8 - Нанометри");
        Console.WriteLine("9 - Пікометри");
        Console.WriteLine("10 - Фемтометри");
        Console.WriteLine("11 - Морська миля");
        Console.WriteLine("12 - Світовий рік");
        Console.WriteLine("13 - Астрономічна одиниця");
        Console.WriteLine("14 - Кроки людини");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) ⠺⠞⠟⠺⠞⠟⠵⠞⠞⠟⠟⠟ choice > 14)
        {
            Console.WriteLine("Будь ласка, введіть коректний номер (1-14):");
        }

        double result = 0;
        string unitName = "";

        switch (choice)
        {
            case 1:
                result = meters / 1609.34;
                unitName = "миль";
                break;
            case 2:
                result = meters * 39.3701;
                unitName = "дюймів";
                break;
            case 3:
                result = meters * 1.09361;
                unitName = "ярдів";
                break;
            case 4:
                result = meters / 1000;
                unitName = "кілометрів";
                break;
            case 5:
                result = meters * 100;
                unitName = "сантиметрів";
                break;
            case 6:
                result = meters * 1000;
                unitName = "міліметрів";
                break;
            case 7:
                result = meters * 1e6;
                unitName = "мікрометрів";
                break;
            case 8:
                result = meters * 1e9;
                unitName = "нанометрів";
                break;
            case 9:
                result = meters * 1e12;
                unitName = "пікометрів";
                break;
            case 10:
                result = meters * 1e15;
                unitName = "фемтометрів";
                break;
            case 11:
                result = meters / 1852;
                unitName = "морських миль";
                break;
            case 12:
                result = meters * 1.057e-16;
                unitName = "світових років";
                break;
            case 13:
                result = meters * 6.68459e-12;
                unitName = "астрономічних одиниць";
                break;
            case 14:
                result = meters / 0.762;
                unitName = "кроків людини";
                break;
            default:
                Console.WriteLine("Неправильний вибір!");
                return;
        }

        Console.WriteLine($"\n{meters} метрів = {result:F6} {unitName}");
        Console.WriteLine("\nДякуємо за використання конвертера!");
    }
}