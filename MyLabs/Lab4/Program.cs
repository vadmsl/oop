using System;

namespace LabWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню");
                Console.WriteLine("1. Середнє арифметичне");
                Console.WriteLine("2. Паліндром");
                Console.WriteLine("3. Парні числа");
                Console.WriteLine("4. Сума додатніх (через функцію)");
                Console.WriteLine("5. Пошук індексу");
                Console.WriteLine("6. Добуток від’ємних (через функцію)");
                Console.WriteLine("0. Вихід");
                Console.WriteLine(" ");
                Console.Write("Виберіть завдання: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                if (choice == "0") break;

                switch (choice)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "4":
                        Task4();
                        break;
                    case "5":
                        Task5();
                        break;
                    case "6":
                        Task6();
                        break;
                    default:
                        Console.WriteLine("Невірний вибір, спробуй ще раз.");
                        break;
                }

                Console.WriteLine("\nНажми Enter щоб продовжити...");
                Console.ReadLine();
            }
        }
        static void Task1()
        {
            Console.WriteLine("Середнє арифметичне");
            Console.WriteLine("Введіть числа через пробіл:");
            
            string line = Console.ReadLine();
            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            int[] mas = new int[parts.Length];
            
            for (int i = 0; i < parts.Length; i++)
            {
                mas[i] = int.Parse(parts[i]);
            }

            double sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }

            double avg = sum / mas.Length;
            Console.WriteLine("Середнє арифметичне: " + avg);
        }

        static void Task2()
        {
            Console.WriteLine("Паліндром");
            Console.WriteLine("Введіть масив:");
            
            string line = Console.ReadLine();
            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] mas = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++) mas[i] = int.Parse(parts[i]);

            bool flag = true;
            for (int i = 0; i < mas.Length / 2; i++)
            {
                if (mas[i] != mas[mas.Length - 1 - i])
                {
                    flag = false;
                    break; 
                }
            }

            if (flag) Console.WriteLine("Так, це паліндром.");
            else Console.WriteLine("Ні, це не паліндром.");
        }

        static void Task3()
        {
            Console.WriteLine("Парні числа");
            Console.WriteLine("Введіть масив:");

            string line = Console.ReadLine();
            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] mas = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++) mas[i] = int.Parse(parts[i]);

            Console.Write("Парні числа: ");
            bool found = false;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] % 2 == 0)
                {
                    Console.Write(mas[i] + " ");
                    found = true;
                }
            }
            if (found == false) Console.Write("немає");
            Console.WriteLine();
        }

        static void Task4()
        {
            Console.WriteLine("Сума додатніх");
            Console.WriteLine("Введіть масив:");

            string line = Console.ReadLine();
            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] mas = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++) mas[i] = int.Parse(parts[i]);

            int result = SumPositive(mas);
            Console.WriteLine("Сума додатніх елементів: " + result);
        }
        static int SumPositive(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        static void Task5()
        {
            Console.WriteLine("Пошук індексу");
            Console.WriteLine("Введіть масив:");

            string line = Console.ReadLine();
            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] mas = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++) mas[i] = int.Parse(parts[i]);

            Console.Write("Введіть число, яке шукаємо: ");
            int x = int.Parse(Console.ReadLine());
            
            int index = -1;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == x)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
                Console.WriteLine("Число знайдено під індексом: " + index);
            else
                Console.WriteLine("Такого числа немає в масиві.");
        }

        static void Task6()
        {
            Console.WriteLine("Добуток від’ємних");
            Console.WriteLine("Введіть масив:");

            string line = Console.ReadLine();
            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] mas = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++) mas[i] = int.Parse(parts[i]);

            long result = ProdNegative(mas);

            if (result == 0)
                Console.WriteLine("Від'ємних чисел немає.");
            else
                Console.WriteLine("Добуток від'ємних: " + result);
        }

        static long ProdNegative(int[] arr)
        {
            long prod = 1;
            bool hasNeg = false; 

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    prod = prod * arr[i];
                    hasNeg = true;
                }
            }

            if (hasNeg == true) return prod;
            else return 0;
        }
    }
}