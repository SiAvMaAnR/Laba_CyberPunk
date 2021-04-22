using LibraryStates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Logic
    {
        private static List<State> states = new List<State>();
        public static List<State> States 
        { 
            get
            {
                return states;
            }
            set
            {
                states = value;
            }
        }

        //Добавление данных
        public static void AddState()
        {
            Console.Clear();
            Console.WriteLine("1 - Республика / 2 - Монархия / 3 - Королевство");
            Console.Write("Сделайте выбор: ");
            try
            {
                switch (Console.ReadLine())
                {
                    case "1": States.Add(SetRepublic()); break;
                    case "2": States.Add(SetMonarchy()); break;
                    case "3": States.Add(SetKingdom()); break;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Ввод данных республики
        public static Republic SetRepublic()
        {
            try
            {
                Console.Clear();

                string Name;
                do
                {
                    Console.Write("Введите Название: ");
                    Name = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(Name));

                string Capital;
                do
                {
                    Console.Write("Введите Столицу: ");
                    Capital = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(Capital));

                int YearOfFoundation;
                do
                {
                    Console.Write("Введите Возраст: ");
                }
                while (!int.TryParse(Console.ReadLine(), out YearOfFoundation));

                string President;
                do
                {
                    Console.Write("Введите Президента: ");
                    President = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(President));

                string KindOfRepublic;
                do
                {
                    Console.Write("Введите Вид республики: ");
                    KindOfRepublic = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(KindOfRepublic));

                return new Republic(Name,Capital,YearOfFoundation,President,KindOfRepublic);
            }
            catch(Exception ex) 
            {
                throw ex;
            };
        }

        //Ввод данных монархии
        public static Monarchy SetMonarchy()
        {
            try
            {
                Console.Clear();

                string Name;
                do
                {
                    Console.Write("Введите Название: ");
                    Name = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(Name));

                string Capital;
                do
                {
                    Console.Write("Введите Столицу: ");
                    Capital = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(Capital));

                int YearOfFoundation;
                do
                {
                    Console.Write("Введите Возраст: ");
                }
                while (!int.TryParse(Console.ReadLine(), out YearOfFoundation));

                string Monarch;
                do
                {
                    Console.Write("Введите Монарха: ");
                    Monarch = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(Monarch));


                string KindOfMonarchy;
                do
                {
                    Console.Write("Введите Вид монархии: ");
                    KindOfMonarchy = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(KindOfMonarchy));
                
                return new Monarchy(Name, Capital, YearOfFoundation, Monarch, KindOfMonarchy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Ввод данных королевства
        public static Kingdom SetKingdom()
        {
            try
            {
                Console.Clear();

                string Name;
                do
                {
                    Console.Write("Введите Название: ");
                    Name = Console.ReadLine();
                } 
                while (string.IsNullOrEmpty(Name));

                string Capital;
                do
                {
                    Console.Write("Введите Столицу: ");
                    Capital = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(Capital));

                int YearOfFoundation;
                do
                {
                    Console.Write("Введите Возраст: ");
                }
                while (!int.TryParse(Console.ReadLine(), out YearOfFoundation));

                string King;
                do
                {
                    Console.Write("Введите Короля: ");
                    King = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(King));

                string KindOfKingdom;
                do
                {
                    Console.Write("Введите Вид королевства: ");
                    KindOfKingdom = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(KindOfKingdom));

                return new Kingdom(Name, Capital, YearOfFoundation, King, KindOfKingdom);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Вывод данных
        public static void ShowState()
        {
            Console.Clear();
            foreach (var item in States)
            {
                Console.WriteLine(item.StateToString());
            }
            Console.ReadKey();
        }

        //Поиск данных
        public static void SearchState()
        {
            Console.Clear();
            Console.Write("Введите текст для поиска: ");
            string searchText = Console.ReadLine();

            foreach (var item in States)
            {
                if (item.IsContains(searchText))
                {
                    Console.WriteLine(item.StateToString());
                }
            }
            Console.ReadKey();
        }
    }
}
