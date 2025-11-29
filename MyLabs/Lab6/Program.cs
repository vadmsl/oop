using System;

namespace Lab6
{
    class Person
    {
        private string name;
        private DateTime birthYear;

        public string Name
        {
            get { return name; }
        }

        public DateTime BirthYear
        {
            get { return birthYear; }
        }

        public Person()
        {
            name = "Unknown";
            birthYear = DateTime.Now;
        }

        public Person(string n, DateTime b)
        {
            name = n;
            birthYear = b;
        }

        public int Age()
        {
            return DateTime.Now.Year - birthYear.Year;
        }

        public void Input()
        {
            Console.Write("Введіть ім'я: ");
            name = Console.ReadLine();

            Console.Write("Введіть дату народження (рік-місяць-день): ");
            birthYear = DateTime.Parse(Console.ReadLine());
        }

        public void ChangeName(string newName)
        {
            name = newName;
        }

        public override string ToString()
        {
            return "Ім'я: " + name + ", Дата: " + birthYear.ToShortDateString() + ", Вік: " + Age();
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }

        public static bool operator ==(Person p1, Person p2)
        {
            if (object.ReferenceEquals(p1, null) || object.ReferenceEquals(p2, null))
                return false;
            
            return p1.name == p2.name;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return !(p1 == p2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[6];

            Console.WriteLine("Введення даних для 6 осіб:");
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"\nОсоба #{i + 1}:");
                people[i] = new Person(); 
                people[i].Input();        
            }

            Console.WriteLine("\nІм'я та вік кожної особи:");
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"{people[i].Name} - {people[i].Age()} років");
            }

            for (int i = 0; i < people.Length; i++)
            {
                if (people[i].Age() < 16)
                {
                    people[i].ChangeName("Very Young");
                }
            }

            Console.WriteLine("\nІнформація про всіх після перевірки віку:");
            foreach (Person p in people)
            {
                p.Output();
            }

            Console.WriteLine("\nПошук осіб з однаковими іменами:");
            bool found = false;
            
            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i] == people[j])
                    {
                        Console.WriteLine($"Збіг імен знайдено: {people[i].Name}");
                        people[i].Output();
                        people[j].Output();
                        Console.WriteLine("-"); 
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("Осіб з однаковими іменами не знайдено.");
            }

            Console.ReadLine(); 
        }
    }
}