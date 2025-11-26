using System;

namespace Lab4
{
    class Car
    {
        public string Name;
        public string Color;
        public double Price;
        public const string CompanyName = "MyDealership";

        public Car()
        {
        }

        public Car(string n, string c, double p)
        {
            Name = n;
            Color = c;
            Price = p;
        }

        public void Input()
        {
            Console.Write("Введіть назву: ");
            Name = Console.ReadLine();
            Console.Write("Введіть колір: ");
            Color = Console.ReadLine();
            Console.Write("Введіть ціну: ");
            Price = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine($"Авто: {Name}, Колір: {Color}, Ціна: {Price}, Компанія: {CompanyName}");
        }

        public void ChangePrice(double x)
        {
            double discount = Price * x / 100;
            Price -= discount;
        }

        public string PrintInfo()
        {
            return "Авто: " + Name + " Колір: " + Color + " Ціна: " + Price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Car[] arr = new Car[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Авто номер " + (i + 1));
                arr[i] = new Car();
                arr[i].Input();
            }

            Console.WriteLine("\nЗнижка 10%:");
            for (int i = 0; i < 3; i++)
            {
                arr[i].ChangePrice(10);
                arr[i].Print();
            }

            Console.Write("\nВведіть новий колір замість white: ");
            string newColor = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                if (arr[i].Color == "white")
                {
                    arr[i].Color = newColor;
                }
            }

            Console.WriteLine("\nРезультат:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i].PrintInfo());
            }
            
            Console.ReadKey();
        }
    }
}