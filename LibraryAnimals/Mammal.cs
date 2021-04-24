using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAnimals
{
    //Млекопитающее
    public class Mammal : Animal
    {
        private readonly string Type = "Млекопитающее";

        //Скорость
        private int speed;
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        //Пищевой рацион
        private int foodRation;
        public int FoodRation
        {
            get
            {
                return foodRation;
            }
            set
            {
                foodRation = value;
            }
        }

        public Mammal(string Name, int Weight, int Age, int Speed, int FoodRation)
        {
            try
            {
                this.Name = Name;
                this.Weight = Weight;
                this.Age = Age;
                this.Speed = Speed;
                this.FoodRation = FoodRation;
            }
            catch (Exception ex)
            {
                throw ex;
            };
        }

        //Вернуть тип животного
        public override string GetTypeAnimal() => Type;

        //Вернуть данные о животном
        public override string AnimalToString()
        {
            return $"Название - {Name} / Масса - {Weight} / Возраст - {Age} / Скорость - {Speed} / Пищевой рацион - {FoodRation}";
        }

        //Проверка на содержание в полях совпадений
        public override bool IsContains(string searchText)
        {
            return (Name == searchText || Weight.ToString() == searchText || Age.ToString() == searchText || Speed.ToString() == searchText || FoodRation.ToString() == searchText);
        }
    }
}
