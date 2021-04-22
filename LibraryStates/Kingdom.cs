using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStates
{
    public class Kingdom : State
    {
        readonly string Type = "Королевство";

        //Король
        private string king;
        public string King
        {
            get
            {
                return king;
            }
            set
            {
                king = value;
            }
        }

        //Вид королевства
        private string kindOfKingdom;
        public string KindOfKingdom
        {
            get
            {
                return kindOfKingdom;
            }
            set
            {
                kindOfKingdom = value;
            }
        }

        public Kingdom(string Name, string Capital, int YearOfFoundation, string King, string KindOfKingdom)
        {
            try
            {
                this.Name = Name;
                this.Capital = Capital;
                this.YearOfFoundation = YearOfFoundation;
                this.King = King;
                this.KindOfKingdom = KindOfKingdom;
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
            return $"{Type}: Название - {Name} / Столица - {Capital} / Возраст - {YearOfFoundation} / Король - {King} / Вид королевства - {KindOfKingdom}";
        }

        //Проверка на содержание в полях совпадений
        public override bool IsContains(string searchText)
        {
            if (Name == searchText ||
                Capital == searchText ||
                YearOfFoundation.ToString() == searchText ||
                King == searchText ||
                KindOfKingdom == searchText)
                return true;
            else
                return false;
        }
    }
}
