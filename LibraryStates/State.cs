using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStates
{
    public abstract class State
    {
        //Название
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //Столица
        private string capital;
        public string Capital
        {
            get
            {
                return capital;
            }
            set
            {
                capital = value;
            }
        }

        //Количество лет
        private int yearOfFoundation;
        public int YearOfFoundation
        {
            get
            {
                return yearOfFoundation;
            }
            set
            {
                yearOfFoundation = value;
            }
        }

        //Вернуть форму государства
        public abstract string GetTypeStates();

        //Вывести государство в консоль
        public abstract string StateToString();

        //Проверка на содержание в полях совпадений
        public abstract bool IsContains(string searchText);
    }
}
