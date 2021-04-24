using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAnimals
{
    //Парнокопытное
    public class ClovenHoofed : Animal
    {
        private readonly string Type = "Парнокопытное";

        //Диаметр копыта
        private int hoofDiameter; 
        public int HoofDiameter
        {
            get
            {
                return hoofDiameter;
            }
            set
            {
                hoofDiameter = value;
            }
        }

        //Длина тела
        private int bodyLength;
        public int BodyLength
        {
            get
            {
                return bodyLength;
            }
            set
            {
                bodyLength = value;
            }
        }

        public ClovenHoofed(string Name, int Weight, int Age, int HoofDiameter, int BodyLength)
        {
            try
            {
                this.Name = Name;
                this.Weight = Weight;
                this.Age = Age;
                this.HoofDiameter = HoofDiameter;
                this.BodyLength = BodyLength;
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
            return $"Название - {Name} / Масса - {Weight} / Возраст - {Age} / Диаметр копыта - {HoofDiameter} / Длина тела - {BodyLength}";
        }

        //Проверка на содержание в полях совпадений
        public override bool IsContains(string searchText)
        {
            bool isContains = (Name == searchText || Weight.ToString() == searchText || Age.ToString() == searchText || HoofDiameter.ToString() == searchText || BodyLength.ToString() == searchText);

            return (isContains) ? true : false;
        }
    }
}
