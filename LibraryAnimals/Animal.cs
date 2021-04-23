using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAnimals
{
    public abstract class Animal
    {
        //Имя
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

        //Масса
        private int weight;
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        //Возраст
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        //Вернуть форму животного
        public abstract string GetTypeAnimal();

        //Вывести животное в консоль
        public abstract string AnimalToString();

        //Проверка на содержание в полях совпадений
        public abstract bool IsContains(string searchText);
    }
}
