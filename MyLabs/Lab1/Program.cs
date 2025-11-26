using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear(); 
            Console.WriteLine("Меню");
            Console.WriteLine("1 - Перевірка Дня та Місяця");
            Console.WriteLine("2 - Сума дробових чисел (3.45 -> 4+5)");
            Console.WriteLine("3 - Привітання за часом");
            Console.WriteLine("4 - Знайти Max та Min з трьох чисел");
            Console.WriteLine("5 - Площа прямокутника");
            Console.WriteLine("6 - Парне чи Непарне");
            Console.WriteLine("7 - Конвертер Цельсій -> Фаренгейт");
            Console.WriteLine("8 - Сума чисел від 1 до N");
            Console.WriteLine("0 - ВИХІД");
            Console.WriteLine(" ");
            Console.Write("Обери номер завдання: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Task1_DateCheck(); break;
                case "2": Task2_FractionSum(); break;
                case "3": Task3_Greeting(); break;
                case "4": Task4_MinMax(); break;
                case "5": Task5_RectangleArea(); break;
                case "6": Task6_EvenOdd(); break;
                case "7": Task7_Temperature(); break;
                case "8": Task8_SumN(); break;
                case "0": return; 
                default:
                    Console.WriteLine("Невірний вибір. Спробуй ще раз.");
                    break;
            }

            Console.WriteLine("\nНатисни Enter, щоб повернутись в меню...");
            Console.ReadLine();
        }
    }

    static void Task1_DateCheck()
    {
        Console.WriteLine("\nПеревірка дати");
        Console.Write("Введіть перше число: ");
        int n1 = int.Parse(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        int n2 = int.Parse(Console.ReadLine());

        bool variant1 = (n1 >= 1 && n1 <= 31) && (n2 >= 1 && n2 <= 12);
        bool variant2 = (n2 >= 1 && n2 <= 31) && (n1 >= 1 && n1 <= 12);

        if (variant1 || variant2)
            Console.WriteLine("Так, це може бути день і місяць.");
        else
            Console.WriteLine("Ні, це не схоже на дату.");
    }

    static void Task2_FractionSum()
    {
        Console.WriteLine("\nСума дробових цифр");
        Console.Write("Введіть число (через кому або крапку): ");
        double realNum = double.Parse(Console.ReadLine());
        
        double fractionalPart = Math.Abs(realNum - (int)realNum);
        int digit1 = (int)(fractionalPart * 10);
        int digit2 = (int)(fractionalPart * 100) % 10;

        Console.WriteLine($"Цифри: {digit1} і {digit2}. Сума: {digit1 + digit2}");
    }

    static void Task3_Greeting()
    {
        Console.WriteLine("\nПривітання");
        Console.Write("Котра година (0-23): ");
        int h = int.Parse(Console.ReadLine());

        if (h >= 6 && h < 12) Console.WriteLine("Доброго ранку!");
        else if (h >= 12 && h < 18) Console.WriteLine("Добрий день!");
        else if (h >= 18 && h < 23) Console.WriteLine("Добрий вечір!");
        else if (h >= 23 && h < 6) Console.WriteLine("Доброї ночі!");
        else Console.WriteLine("Невірний час.");
    }

    static void Task4_MinMax()
    {
        Console.WriteLine("\nMin/Max");
        Console.Write("Число A: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Число B: "); int b = int.Parse(Console.ReadLine());
        Console.Write("Число C: "); int c = int.Parse(Console.ReadLine());

        Console.WriteLine($"Max: {Math.Max(a, Math.Max(b, c))}");
        Console.WriteLine($"Min: {Math.Min(a, Math.Min(b, c))}");
    }

    static void Task5_RectangleArea()
    {
        Console.WriteLine("\nПлоща прямокутника");
        Console.Write("Довжина: "); double l = double.Parse(Console.ReadLine());
        Console.Write("Ширина: "); double w = double.Parse(Console.ReadLine());
        Console.WriteLine($"Площа: {l * w}");
    }

    static void Task6_EvenOdd()
    {
        Console.WriteLine("\nПарне/Непарне");
        Console.Write("Число: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 ? "Парне" : "Непарне");
    }

    static void Task7_Temperature()
    {
        Console.WriteLine("\nC -> F");
        Console.Write("Градуси Цельсія: ");
        double c = double.Parse(Console.ReadLine());
        double f = c * 9.0 / 5.0 + 32;
        Console.WriteLine($"Фаренгейт: {f}");
    }

    static void Task8_SumN()
    {
        Console.WriteLine("\nСума 1..N");
        Console.Write("Введіть N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++) sum += i;
        Console.WriteLine($"Сума: {sum}");
    }
}