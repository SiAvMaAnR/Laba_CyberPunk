using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryAnimals;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                PrintMenu();
                switch (Console.ReadLine())
                {
                    case "1": Logic.AddAnimal(); break;
                    case "2": Logic.ShowAnimal();  break;
                    case "3": Logic.SearchAnimal(); break;
                    case "4": Environment.Exit(0); break;
                }
            }
        }

        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine(" 1 - Добавить животное");
            Console.WriteLine(" 2 - Вывод списка животных");
            Console.WriteLine(" 3 - Поиск по животным");
            Console.WriteLine(" 4 - Выход из приложения");
            Console.Write("Выберите нужный вариант: ");
        }
    }
}
