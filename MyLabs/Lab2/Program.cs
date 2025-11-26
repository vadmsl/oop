using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Меню");
            Console.WriteLine("1. Перевірка числа (+, -, 0)");
            Console.WriteLine("2. Високосний рік");
            Console.WriteLine("3. Податок на дохід");
            Console.WriteLine("4. Голосна чи приголосна");
            Console.WriteLine("5. Найбільше з трьох чисел");
            Console.WriteLine("6. Підлітковий вік");
            Console.WriteLine("7. Парність і ділення на 3");
            Console.WriteLine("8. Найдовша сторона трикутника");
            Console.WriteLine("0. Вихід");
            Console.Write("\nВведіть номер завдання: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": Task1(); break;
                case "2": Task2(); break;
                case "3": Task3(); break;
                case "4": Task4(); break;
                case "5": Task5(); break;
                case "6": Task6(); break;
                case "7": Task7(); break;
                case "8": Task8(); break;
                case "0": return;
                default:
                    Console.WriteLine("Невірний вибір!");
                    break;
            }
            Console.WriteLine("\nНатисніть будь-яку клавішу, щоб продовжити...");
            Console.ReadKey();
        }
    }

    static void Task1()
    {
        Console.Write("Введіть число: ");
        if (double.TryParse(Console.ReadLine(), out double num))
        {
            if (num > 0) Console.WriteLine("Число додатнє.");
            else if (num < 0) Console.WriteLine("Число від'ємне.");
            else Console.WriteLine("Число рівне нулю.");
        }
        else Console.WriteLine("Помилка введення.");
    }

    static void Task2()
    {
        Console.Write("Введіть рік: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            Console.WriteLine("Рік високосним.");
        else
            Console.WriteLine("Рік звичайний (не високосний).");
    }

    static void Task3()
    {
        Console.Write("Введіть річний дохід: ");
        double income = Convert.ToDouble(Console.ReadLine());
        double tax = 0;
        if (income > 50000) tax = income * 0.20;
        else if (income > 10000) tax = income * 0.10;
        Console.WriteLine($"Податок складає: {tax}");
    }

    static void Task4()
    {
        Console.Write("Введіть букву: ");
        char l = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();
        if ("aeiou".IndexOf(l) >= 0) Console.WriteLine("Це голосна.");
        else if (char.IsLetter(l)) Console.WriteLine("Це приголосна.");
        else Console.WriteLine("Це не буква.");
    }

    static void Task5()
    {
        Console.Write("Число 1: "); double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Число 2: "); double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Число 3: "); double c = Convert.ToDouble(Console.ReadLine());
        double max = a;
        if (b > max) max = b;
        if (c > max) max = c;
        Console.WriteLine($"Найбільше: {max}");
    }

    static void Task6()
    {
        Console.Write("Введіть вік: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age >= 12 && age <= 18) Console.WriteLine("Підлітковий вік.");
        else Console.WriteLine("Не підлітковий вік.");
    }

    static void Task7()
    {
        Console.Write("Введіть число: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string even = (n % 2 == 0) ? "парне" : "непарне";
        string div3 = (n % 3 == 0) ? "ділиться на 3" : "не ділиться на 3";
        Console.WriteLine($"Число {even} і {div3}.");
    }

    static void Task8()
    {
        Console.Write("Сторона A: "); double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Сторона B: "); double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Сторона C: "); double c = Convert.ToDouble(Console.ReadLine());
        if (a >= b && a >= c) Console.WriteLine("A найдовша.");
        else if (b >= a && b >= c) Console.WriteLine("B найдовша.");
        else Console.WriteLine("C найдовша.");
    }
}