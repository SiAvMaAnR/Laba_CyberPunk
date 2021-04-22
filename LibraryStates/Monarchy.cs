using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStates
{
    public class Monarchy : State
    {
        readonly string Type = "Монархия";

        //Монарх
        private string monarch;
        public string Monarch
        {
            get
            {
                return monarch;
            }
            set
            {
                monarch = value;
            }
        }

        //Вид монархии
        private string kindOfMonarchy;
        public string KindOfMonarchy
        {
            get
            {
                return kindOfMonarchy;
            }
            set
            {
                kindOfMonarchy = value;
            }
        }

        public Monarchy(string Name, string Capital, int YearOfFoundation, string Monarch, string KindOfMonarchy)
        {
            try
            {
                this.Name = Name;
                this.Capital = Capital;
                this.YearOfFoundation = YearOfFoundation;
                this.Monarch = Monarch;
                this.KindOfMonarchy = KindOfMonarchy;
            }
            catch (Exception ex)
            {
                throw ex;
            };
        }

        //Вернуть форму государства
        public override string GetTypeStates()
        {
            return Type;
        }

        //Вывести государство в консоль
        public override string StateToString()
        {
            return $"{Type}: Название - {Name} / Столица - {Capital} / Возраст - {YearOfFoundation} / Монарх - {Monarch} / Вид монархии - {KindOfMonarchy}";
        }

        //Проверка на содержание в полях совпадений
        public override bool IsContains(string searchText)
        {
            if (Name == searchText ||
                Capital == searchText ||
                YearOfFoundation.ToString() == searchText ||
                Monarch == searchText ||
                KindOfMonarchy == searchText)
                return true;
            else
                return false;
        }
    }
}
