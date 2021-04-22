using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryStates;

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
                    case "1": Logic.AddState(); break;
                    case "2": Logic.ShowState();  break;
                    case "3": Logic.SearchState(); break;
                    case "4": Environment.Exit(1); break;
                }
            }
        }

        static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine(" 1 - Добавить государство");
            Console.WriteLine(" 2 - Вывод списка государств");
            Console.WriteLine(" 3 - Поиск по государствам");
            Console.WriteLine(" 4 - Выход из приложения");
            Console.Write("Выберите нужный вариант: ");
        }
    }
}
