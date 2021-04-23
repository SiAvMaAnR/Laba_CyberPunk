using LibraryAnimals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Logic
    {
        private static List<Animal> animals = new List<Animal>();
        public static List<Animal> Animals
        { 
            get
            {
                return animals;
            }
            set
            {
                animals = value;
            }
        }

        //Добавление данных
        public static void AddAnimal()
        {
            Console.Clear();
            Console.WriteLine("1 - Птица / 2 - Млекопитающее / 3 - Парнокопытное");
            Console.Write("Сделайте выбор: ");
            try
            {
                switch (Console.ReadLine())
                {
                    case "1": Animals.Add(SetBird()); break;
                    case "2": Animals.Add(SetMammal()); break;
                    case "3": Animals.Add(SetClovenHoofed()); break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Вывод данных
        public static void ShowAnimal()
        {
            Console.Clear();
            foreach (var item in Animals)
            {
                Console.WriteLine($"{item.GetTypeAnimal()}: {item.AnimalToString()}");
            }
            Console.ReadKey();
        }

        //Поиск данных
        public static void SearchAnimal()
        {
            Console.Clear();
            Console.Write("Введите текст для поиска: ");
            string searchText = Console.ReadLine();

            foreach (var item in Animals)
            {
                if (item.IsContains(searchText))
                {
                    Console.WriteLine(item.AnimalToString());
                }
            }
            Console.ReadKey();
        }

        //Ввод данных Птицы
        public static Bird SetBird()
        {
            try
            {
                Console.Clear();

                string Name;
                do
                {
                    Console.Write("Введите имя животного: ");
                    Name = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(Name));

                int Weight;
                do
                {
                    Console.Write("Введите массу животного: ");
                }
                while (!int.TryParse(Console.ReadLine(), out Weight));

                int Age;
                do
                {
                    Console.Write("Введите Возраст: ");
                }
                while (!int.TryParse(Console.ReadLine(), out Age));

                int FlightAltitude;
                do
                {
                    Console.Write("Введите высоту полета: ");
                }
                while (!int.TryParse(Console.ReadLine(), out FlightAltitude));

                int FlightSpeed;
                do
                {
                    Console.Write("Введите скорость полета: ");
                }
                while (!int.TryParse(Console.ReadLine(), out FlightSpeed));

                return new Bird(Name,Weight,Age,FlightAltitude,FlightSpeed);
            }
            catch(Exception ex) 
            {
                throw ex;
            };
        }

        //Ввод данных Млекопитающего
        public static Mammal SetMammal()
        {
            try
            {
                Console.Clear();

                string Name;
                do
                {
                    Console.Write("Введите имя животного: ");
                    Name = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(Name));

                int Weight;
                do
                {
                    Console.Write("Введите массу животного: ");
                }
                while (!int.TryParse(Console.ReadLine(), out Weight));

                int Age;
                do
                {
                    Console.Write("Введите Возраст: ");
                }
                while (!int.TryParse(Console.ReadLine(), out Age));

                int Speed;
                do
                {
                    Console.Write("Введите скорость бега: ");
                }
                while (!int.TryParse(Console.ReadLine(), out Speed));

                int FoodRation;
                do
                {
                    Console.Write("Введите пищевой рацион: ");
                }
                while (!int.TryParse(Console.ReadLine(), out FoodRation));

                return new Mammal(Name, Weight, Age, Speed, FoodRation);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Ввод данных Парнокопытного
        public static ClovenHoofed SetClovenHoofed()
        {
            try
            {
                Console.Clear();

                string Name;
                do
                {
                    Console.Write("Введите имя животного: ");
                    Name = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(Name));

                int Weight;
                do
                {
                    Console.Write("Введите массу животного: ");
                }
                while (!int.TryParse(Console.ReadLine(), out Weight));

                int Age;
                do
                {
                    Console.Write("Введите Возраст: ");
                }
                while (!int.TryParse(Console.ReadLine(), out Age));

                int HoofDiameter;
                do
                {
                    Console.Write("Введите диаметр копыта: ");
                }
                while (!int.TryParse(Console.ReadLine(), out HoofDiameter));

                int BodyLength;
                do
                {
                    Console.Write("Введите длина тела: ");
                }
                while (!int.TryParse(Console.ReadLine(), out BodyLength));

                return new ClovenHoofed(Name, Weight, Age, HoofDiameter, BodyLength);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
