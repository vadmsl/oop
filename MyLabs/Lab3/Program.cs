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
            Console.WriteLine("1. Парні числа від 1 до 20");
            Console.WriteLine("2. Сума чисел від 1 до 100");
            Console.WriteLine("3. Таблиця множення");
            Console.WriteLine("4. Факторіал числа");
            Console.WriteLine("5. Сума простих чисел (1-50)");
            Console.WriteLine("6. Переведення в двійкову систему");
            Console.WriteLine("7. Числа Фібоначчі (сума та кількість)");
            Console.WriteLine("8. НСД двох чисел");
            Console.WriteLine("0. Вихід");
            Console.WriteLine(" ");
            Console.Write("Ваш вибір: ");

            string choice = Console.ReadLine();

            Console.WriteLine(); 

            switch (choice)
            {
                case "1":
                    Task1_EvenNumbers();
                    break;
                case "2":
                    Task2_Sum1to100();
                    break;
                case "3":
                    Task3_MultiplicationTable();
                    break;
                case "4":
                    Task4_Factorial();
                    break;
                case "5":
                    Task5_SumPrimes();
                    break;
                case "6":
                    Task6_ToBinary();
                    break;
                case "7":
                    Task7_Fibonacci();
                    break;
                case "8":
                    Task8_GCD();
                    break;
                case "0":
                    Console.WriteLine("До побачення!");
                    return; 
                default:
                    Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                    break;
            }

            Console.WriteLine("\nНатисніть будь-яку клавішу, щоб повернутися в меню...");
            Console.ReadKey();
        }
    }

    static void Task1_EvenNumbers()
    {
        Console.WriteLine("--- Парні числа від 1 до 20 ---");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0) Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    static void Task2_Sum1to100()
    {
        Console.WriteLine("--- Сума чисел від 1 до 100 ---");
        int sum = 0;
        for (int i = 1; i <= 100; i++) sum += i;
        Console.WriteLine($"Сума: {sum}");
    }

    static void Task3_MultiplicationTable()
    {
        Console.WriteLine("--- Таблиця множення ---");
        Console.Write("Введіть число: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
        else Console.WriteLine("Помилка введення!");
    }

    static void Task4_Factorial()
    {
        Console.WriteLine("--- Факторіал ---");
        Console.Write("Введіть число: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++) factorial *= i;
            Console.WriteLine($"Факторіал {n}! = {factorial}");
        }
        else Console.WriteLine("Введіть коректне невід'ємне число!");
    }

    static void Task5_SumPrimes()
    {
        Console.WriteLine("--- Сума простих чисел (1-50) ---");
        int sumPrimes = 0;
        Console.Write("Прості числа: ");
        
        for (int i = 2; i <= 50; i++)
        {
            bool isPrime = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write(i + " ");
                sumPrimes += i;
            }
        }
        Console.WriteLine($"\nСума: {sumPrimes}");
    }

    static void Task6_ToBinary()
    {
        Console.WriteLine("--- Переведення в двійкову систему ---");
        Console.Write("Введіть десяткове число: ");
        if (int.TryParse(Console.ReadLine(), out int decimalNumber))
        {
            string binaryResult = "";
            int tempNumber = decimalNumber;

            if (decimalNumber == 0) binaryResult = "0";
            else
            {
                while (tempNumber > 0)
                {
                    binaryResult = (tempNumber % 2) + binaryResult;
                    tempNumber /= 2;
                }
            }
            Console.WriteLine($"Число {decimalNumber} у двійковій: {binaryResult}");
        }
        else Console.WriteLine("Помилка введення!");
    }

    static void Task7_Fibonacci()
    {
        Console.WriteLine("--- Числа Фібоначчі ---");
        Console.Write("Введіть верхню межу: ");
        if (int.TryParse(Console.ReadLine(), out int limit))
        {
            int a = 0, b = 1, sumFib = 0, count = 0;
            Console.Write("Послідовність: ");

            if (a < limit) { sumFib += a; count++; Console.Write(a + " "); }
            
            while (b < limit)
            {
                sumFib += b;
                count++;
                Console.Write(b + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine($"\nСума: {sumFib}, Кількість: {count}");
        }
        else Console.WriteLine("Помилка введення!");
    }

    static void Task8_GCD()
    {
        Console.WriteLine("--- НСД (GCD) ---");
        Console.Write("Введіть перше число: ");
        bool res1 = int.TryParse(Console.ReadLine(), out int num1);
        Console.Write("Введіть друге число: ");
        bool res2 = int.TryParse(Console.ReadLine(), out int num2);

        if (res1 && res2)
        {
            int originalNum1 = num1, originalNum2 = num2;
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }
            Console.WriteLine($"НСД чисел {originalNum1} та {originalNum2} = {num1}");
        }
        else Console.WriteLine("Помилка введення!");
    }
}