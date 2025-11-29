using System;

namespace Lab5
{
    public enum Gender
    {
        Male,
        Female
    }

    public class Cat
    {
        public string Name { get; }
        public Gender Gender { get; }
        private double _energy;
        public static readonly double MaxEnergy = 20;
        public static readonly double MinEnergy = 0;
        public static readonly double SleepEnergyGain = 10;
        public static readonly double JumpEnergyDrain = 0.5;
        public double Energy
        {
            get { return _energy; }
            private set
            {
                if (value < MinEnergy)
                {
                    throw new Exception("Not enough energy to jump");
                }
                
                if (value > MaxEnergy)
                {
                    _energy = MaxEnergy;
                }
                else
                {
                    _energy = value;
                }
            }
        }

        public Cat(string name, Gender gender)
        {
            Name = name;
            Gender = gender;
            Energy = MaxEnergy;
        }

        public void Jump()
        {
            Energy -= JumpEnergyDrain;
            Console.WriteLine($"{Name} стрибнув. Енергія: {Energy}");
        }
        public void Sleep()
        {
            Energy += SleepEnergyGain;
            Console.WriteLine($"{Name} поспав. Енергія: {Energy}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Cat myCat = new Cat("Barsik", Gender.Male);
                Console.WriteLine($"Кіт: {myCat.Name}, Стать: {myCat.Gender}, Енергія: {myCat.Energy}");
                myCat.Jump();
                myCat.Jump();
                myCat.Sleep();

                Console.WriteLine("\nПочинаємо серію стрибків...");
                for (int i = 0; i < 50; i++) 
                {
                    myCat.Jump();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nСталася помилка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}