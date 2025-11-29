using System;

namespace ShapesApp
{
    // Абстрактний клас
    abstract class Shape
    {
        // Поле name (з маленької літери, як в завданні)
        public string name;

        // Конструктор
        public Shape(string n)
        {
            name = n;
        }

        // Властивість
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Абстрактні методи
        public abstract double Area();
        public abstract double Perimeter();
    }

    // Клас Коло
    class Circle : Shape
    {
        public double radius;

        public Circle(string n, double r) : base(n)
        {
            radius = r;
        }

        public override double Area()
        {
            // Використовуємо 3.14 замість Math.PI
            return 3.14 * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * 3.14 * radius;
        }
    }

    // Клас Квадрат
    class Square : Shape
    {
        public double side;

        public Square(string n, double s) : base(n)
        {
            side = s;
        }

        public override double Area()
        {
            return side * side;
        }

        public override double Perimeter()
        {
            return side * 4;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // а) Створити по 2 екземпляри
            Square sq1 = new Square("Square_Small", 4);
            Square sq2 = new Square("Square_Big", 10);

            Circle cr1 = new Circle("Circle_One", 5);
            Circle cr2 = new Circle("Circle_Two", 3);

            // Вивід інформації (просто копіпаст рядків)
            Console.WriteLine("Figure: " + sq1.Name + " | Area: " + sq1.Area() + " | Perimeter: " + sq1.Perimeter());
            Console.WriteLine("Figure: " + sq2.Name + " | Area: " + sq2.Area() + " | Perimeter: " + sq2.Perimeter());
            
            Console.WriteLine("Figure: " + cr1.Name + " | Area: " + cr1.Area() + " | Perimeter: " + cr1.Perimeter());
            Console.WriteLine("Figure: " + cr2.Name + " | Area: " + cr2.Area() + " | Perimeter: " + cr2.Perimeter());

            Console.WriteLine(); 

            // b) Знайти найбільшу площу
            // Для квадратів
            double maxSqArea;
            if (sq1.Area() > sq2.Area())
            {
                maxSqArea = sq1.Area();
            }
            else
            {
                maxSqArea = sq2.Area();
            }
            Console.WriteLine("Max Square Area: " + maxSqArea);

            // Для кіл
            double maxCirArea;
            if (cr1.Area() > cr2.Area())
            {
                maxCirArea = cr1.Area();
            }
            else
            {
                maxCirArea = cr2.Area();
            }
            Console.WriteLine("Max Circle Area: " + maxCirArea);

            Console.ReadKey();
        }
    }
}