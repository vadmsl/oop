using System;

namespace LabTasks
{
    class Figure
    {
        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual double CalculatePerimeter()
        {
            return 0;
        }
    }

    class Circle : Figure
    {
        public double Radius;

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    class Rectangle : Figure
    {
        public double Width;
        public double Height;

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }

    class Fruit
    {
        public string Name;
    }

    class Apple : Fruit
    {
        public string Variety;
        public string Color;
    }

    class Pear : Fruit
    {
        public string Variety;
        public string Color;
    }

    public abstract class Animal
    {
        public float Weight { get; set; }
        public string Color { get; set; }

        public Animal(string color, float weight)
        {
            Color = color;
            Weight = weight;
        }

        public abstract string MakeSound();
    }

    public abstract class AnimalWithTail : Animal
    {
        public float TailLength { get; set; }

        public AnimalWithTail(string color, float weight, float tailLength) 
            : base(color, weight)
        {
            TailLength = tailLength;
        }
    }

    public class Cat : AnimalWithTail
    {
        public Cat(string color, float weight, float tailLength) 
            : base(color, weight, tailLength)
        {
        }

        private string Purr()
        {
            return "purrrrrrrr";
        }

        private string Meow()
        {
            return "Meow";
        }

        public override string MakeSound()
        {
            return Purr() + Meow();
        }

        public override string ToString()
        {
            return $"This is a Cat, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }

    public class Dog : AnimalWithTail
    {
        public Dog(string color, float weight, float tailLength) 
            : base(color, weight, tailLength)
        {
        }

        public override string MakeSound()
        {
            return "Woof";
        }

        public override string ToString()
        {
            return $"This is a Dog, Color = {Color}, Weight = {Weight}, TailLength = {TailLength}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Фігури");
            
            Circle myCircle = new Circle();
            myCircle.Radius = 5;
            Console.WriteLine("Коло (R=5):");
            Console.WriteLine("Площа: " + myCircle.CalculateArea());
            Console.WriteLine("Периметр: " + myCircle.CalculatePerimeter());

            Rectangle myRect = new Rectangle();
            myRect.Width = 4;
            myRect.Height = 6;
            Console.WriteLine("\nПрямокутник (4x6):");
            Console.WriteLine("Площа: " + myRect.CalculateArea());
            Console.WriteLine("Периметр: " + myRect.CalculatePerimeter());


            Console.WriteLine("\n2. Фрукти");

            Apple myApple = new Apple();
            myApple.Name = "Яблуко";
            myApple.Variety = "Голден";
            myApple.Color = "Жовтий";

            Pear myPear = new Pear();
            myPear.Name = "Груша";
            myPear.Variety = "Конференція";
            myPear.Color = "Зелений";

            Console.WriteLine("Фрукт: " + myApple.Name + ", Сорт: " + myApple.Variety + ", Колір: " + myApple.Color);
            Console.WriteLine("Фрукт: " + myPear.Name + ", Сорт: " + myPear.Variety + ", Колір: " + myPear.Color);


            Console.WriteLine("\n3. Тварини");

            Cat myCat = new Cat("Black", 4.5f, 20.5f);
            Dog myDog = new Dog("Brown", 12.0f, 15.0f);

            Console.WriteLine(myCat.ToString());
            Console.WriteLine("Звук кота: " + myCat.MakeSound());

            Console.WriteLine(myDog.ToString());
            Console.WriteLine("Звук собаки: " + myDog.MakeSound());

            Console.ReadKey();
        }
    }
}