using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAnimals
{
    //Птица
    public class Bird: Animal
    {
        private readonly string Type = "Птица";

        //Высота полета
        private int flightAltitude;
        public int FlightAltitude
        {
            get
            {
                return flightAltitude;
            }
            set
            {
                flightAltitude = value;
            }
        }

        //Скорость полета
        private int flightSpeed;
        public int FlightSpeed
        {
            get
            {
                return flightSpeed;
            }
            set
            {
                flightSpeed = value;
            }
        }

        public Bird(string Name, int Weight, int Age, int FlightAltitude, int FlightSpeed)
        {
            try
            {
                this.Name = Name;
                this.Weight = Weight;
                this.Age = Age;
                this.FlightAltitude = FlightAltitude;
                this.FlightSpeed = FlightSpeed;
            }
            catch(Exception ex) 
            {
                throw ex;
            };
        }

        //Вернуть тип животного
        public override string GetTypeAnimal() => Type;

        //Вернуть данные о животном
        public override string AnimalToString()
        {
            return $"Название - {Name} / Масса - {Weight} / Возраст - {Age} / Скорость - {FlightAltitude} / Пищевой рацион - {FlightSpeed}";
        }

        //Проверка на содержание в полях совпадений
        public override bool IsContains(string searchText)
        {
            bool isContains = (Name == searchText || Weight.ToString() == searchText || Age.ToString() == searchText || FlightAltitude.ToString() == searchText || FlightSpeed.ToString() == searchText);

            return (isContains) ? true : false;
        }
    }
}
